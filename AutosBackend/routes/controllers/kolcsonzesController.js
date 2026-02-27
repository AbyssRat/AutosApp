const db = require("../db");

exports.getKolcsonzesek = async (req, res) => {
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
};

exports.getKolcsonzesById = async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Kolcsonzes WHERE id = ?",
    [req.params.id]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "A kölcsönzés nem található." });

  res.json(rows[0]);
};

exports.getKolcsonzesByUgyfel = async (req, res) => {
  const [rows] = await db.query(`
    SELECT k.*
    FROM Kolcsonzes k
    JOIN Ugyfel u ON k.ugyfel_id = u.id
    WHERE u.nev = ?
  `, [req.params.nev]);

  if (rows.length === 0)
    return res.status(404).json({ error: "Nincs ilyen ügyfél vagy nincs kölcsönzése." });

  res.json(rows);
};

exports.createKolcsonzes = async (req, res) => {
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
};
