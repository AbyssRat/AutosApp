const db = require("../db");

exports.getUgyfelek = async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Ugyfel");
  res.json(rows);
};

exports.getUgyfelByNev = async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Ugyfel WHERE nev = ?",
    [req.params.nev]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "Az ügyfél nem található." });

  res.json(rows[0]);
};
