import express from "express";
const app = express();
app.use(express.json());

import pool from "./db";


/* ===============================
   AUTÓK
================================*/

app.get("/autok", (req, res) => {
  res.json(autok);
});

app.get("/autok/:rendszam", (req, res) => {
  const auto = autok.find(a => a.rendszam === req.params.rendszam);
  if (!auto) return res.status(404).json({ error: "Az autó nem található." });
  res.json(auto);
});

/* ===============================
   ÜGYFELEK
================================*/

app.get("/ugyfelek", (req, res) => {
  res.json(ugyfelek);
});

app.get("/ugyfelek/:nev", (req, res) => {
  const ugyfel = ugyfelek.find(u => u.nev === req.params.nev);
  if (!ugyfel) return res.status(404).json({ error: "Az ügyfél nem található." });
  res.json(ugyfel);
});

/* ===============================
   KÖLCSÖNZŐHELYEK
================================*/

app.get("/kolcsonzohelyek", (req, res) => {
  res.json(kolcsonzohelyek);
});

app.get("/kolcsonzohelyek/:id", (req, res) => {
  const hely = kolcsonzohelyek.find(h => h.id == req.params.id);
  if (!hely) return res.status(404).json({ error: "A telephely nem található." });
  res.json(hely);
});

/* ===============================
   KÖLCSÖNZÉSEK
================================*/

app.get("/kolcsonzesek", (req, res) => {
  res.json(kolcsonzesek);
});

app.get("/kolcsonzesek/:id", (req, res) => {
  const kolcsonzes = kolcsonzesek.find(k => k.id == req.params.id);
  if (!kolcsonzes)
    return res.status(404).json({ error: "A kölcsönzés nem található." });

  res.json(kolcsonzes);
});

app.get("/kolcsonzesek/ugyfel/:nev", (req, res) => {
  const ugyfel = ugyfelek.find(u => u.nev === req.params.nev);
  if (!ugyfel)
    return res.status(404).json({ error: "Nincs ilyen ügyfél." });

  const eredmeny = kolcsonzesek.filter(k => k.ugyfel_id === ugyfel.id);
  res.json(eredmeny);
});

/* ===============================
   POST /kolcsonzesek
================================*/

app.post("/kolcsonzesek", (req, res) => {
  const { auto_id, kolcsonzo_id, ugyfel_id, mettol, meddig } = req.body;

  // 🔎 Validáció
  if (!auto_id || !kolcsonzo_id || !ugyfel_id || !mettol || !meddig) {
    return res.status(400).json({ error: "Hiányzó adatok." });
  }

  const auto = autok.find(a => a.id == auto_id);
  if (!auto)
    return res.status(404).json({ error: "Az autó nem található." });

  const ugyfel = ugyfelek.find(u => u.id == ugyfel_id);
  if (!ugyfel)
    return res.status(404).json({ error: "Az ügyfél nem található." });

  const kolcsonzo = kolcsonzohelyek.find(k => k.id == kolcsonzo_id);
  if (!kolcsonzo)
    return res.status(404).json({ error: "A kölcsönzőhely nem található." });

  if (new Date(meddig) <= new Date(mettol)) {
    return res.status(400).json({ error: "Hibás dátumtartomány." });
  }

  const ujKolcsonzes = {
    id: kolcsonzesek.length + 1,
    auto_id,
    kolcsonzo_id,
    ugyfel_id,
    mettol,
    meddig
  };

  kolcsonzesek.push(ujKolcsonzes);

  res.status(201).json(ujKolcsonzes);
});

/* ===============================
   SERVER INDÍTÁS
================================*/

const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Szerver fut: http://localhost:${PORT}`);
});
