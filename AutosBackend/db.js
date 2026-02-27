const mysql = require("mysql2/promise");

const pool = mysql.createPool({
  host: "localhost",
  user: "root",
  password: "", // ide a saját jelszavad
  database: "autokolcsonzes",
  waitForConnections: true,
  connectionLimit: 10
});

module.exports = pool;
