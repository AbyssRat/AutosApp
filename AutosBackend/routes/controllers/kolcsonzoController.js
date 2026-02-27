import db from "../../db.js";

exports.getKolcsonzohelyek = async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Kolcsonzo");
  res.json(rows);
};

exports.getKolcsonzoById = async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Kolcsonzo WHERE id = ?",
    [req.params.id]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "A telephely nem található." });

  res.json(rows[0]);
};
