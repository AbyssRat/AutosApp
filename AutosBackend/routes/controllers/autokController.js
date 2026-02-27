import db from "../../db.js";

exports.getAutok = async (req, res) => {
  const [rows] = await db.query("SELECT * FROM Auto");
  res.json(rows);
};

exports.getAutoByRendszam = async (req, res) => {
  const [rows] = await db.query(
    "SELECT * FROM Auto WHERE rendszam = ?",
    [req.params.rendszam]
  );

  if (rows.length === 0)
    return res.status(404).json({ error: "Az autó nem található." });

  res.json(rows[0]);
};
