import express from "express";
import mysql from "mysql2/promise";
import cors from "cors";
import db from "./db.js";

const app = express();
app.use(cors());
app.use(express.json());


/* ===============================
   AUTÓK
================================*/

// GET /autok
app.get("/autok", async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Auto");
  res.json(rows);
});

// GET /autok/:rendszam
app.get("/autok/:rendszam", async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Auto WHERE rendszam = ?",
    [req.params.rendszam]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "Az autó nem található." });

  res.json(rows[0]);
});

/* ===============================
   ÜGYFELEK
================================*/

app.get("/ugyfelek", async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Ugyfel");
  res.json(rows);
});

app.get("/ugyfelek/:nev", async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Ugyfel WHERE nev = ?",
    [req.params.nev]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "Az ügyfél nem található." });

  res.json(rows[0]);
});

/* ===============================
   KÖLCSÖNZŐHELYEK
================================*/

app.get("/kolcsonzohelyek", async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Kolcsonzo");
  res.json(rows);
});

app.get("/kolcsonzohelyek/:id", async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Kolcsonzo WHERE id = ?",
    [req.params.id]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "A telephely nem található." });

  res.json(rows[0]);
});

/* ===============================
   KÖLCSÖNZÉSEK
================================*/

// GET /kolcsonzesek (JOIN-nal szépen)
app.get("/kolcsonzesek", async (req, res) => {
  const [rows] = await db.query(`
    SELECT 
      k.id,
      u.nev AS ugyfel,
      a.rendszam,
      a.automarka,
      a.automodell,
      a.napi_dij,
      k.mettol,
      k.meddig
    FROM Kolcsonzes k
    JOIN Auto a ON k.auto_id = a.id
    JOIN Ugyfel u ON k.ugyfel_id = u.id
  `);

  res.json(rows);
});

// GET /kolcsonzesek/:id
app.get("/kolcsonzesek/:id", async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Kolcsonzes WHERE id = ?",
    [req.params.id]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "A kölcsönzés nem található." });

  res.json(rows[0]);
});

// GET /kolcsonzesek/ugyfel/:nev
app.get("/kolcsonzesek/ugyfel/:nev", async (req, res) => {
  const [rows] = await db.query(`
    SELECT k.*
    FROM Kolcsonzes k
    JOIN Ugyfel u ON k.ugyfel_id = u.id
    WHERE u.nev = ?
  `, [req.params.nev]);

  if (rows.length === 0)
    return res.status(404).json({ error: "Nincs ilyen ügyfél vagy nincs kölcsönzése." });

  res.json(rows);
});

/* ===============================
   POST /kolcsonzesek
================================*/

app.post("/kolcsonzesek", async (req, res) => {
  const { auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig } = req.body;

  if (!auto_id || !kolcsonzo_id || !ugyfel_id || !mettol || !meddig)
    return res.status(400).json({ error: "Hiányzó adatok." });

  if (new Date(meddig) <= new Date(mettol))
    return res.status(400).json({ error: "Hibás dátumtartomány." });

  try {
    const [result] = await db.query(
      `INSERT INTO Kolcsonzes (auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig)
       VALUES (?, ?, ?, ?, ?)`,
      [auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig]
    );

    res.status(201).json({
      message: "Sikeres hozzáadás",
      id: result.insertId
    });

  } catch (err) {
    res.status(500).json({ error: "Adatbázis hiba", details: err.message });
  }
});

/* ===============================
   SERVER
================================*/

app.listen(3000, () => {
  console.log("Szerver fut: http://localhost:3000");
});
