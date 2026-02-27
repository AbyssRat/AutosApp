const express = require("express");
const cors = require("cors");

const autokRoutes = require("./routes/autok");
const ugyfelekRoutes = require("./routes/ugyfelek");
const kolcsonzoRoutes = require("./routes/kolcsonzohelyek");
const kolcsonzesRoutes = require("./routes/kolcsonzesek");

const app = express();

app.use(cors());
app.use(express.json());

app.use("/autok", autokRoutes);
app.use("/ugyfelek", ugyfelekRoutes);
app.use("/kolcsonzohelyek", kolcsonzoRoutes);
app.use("/kolcsonzesek", kolcsonzesRoutes);

app.listen(3000, () => {
  console.log("Szerver fut: http://localhost:3000");
});
