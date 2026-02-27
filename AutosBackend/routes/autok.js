const express = require("express");
const router = express.Router();
const controller = require("../controllers/autokController");

router.get("/", controller.getAutok);
router.get("/:rendszam", controller.getAutoByRendszam);

module.exports = router;
