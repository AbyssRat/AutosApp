const express = require("express");
const router = express.Router();
const controller = require("../controllers/kolcsonzesController");

router.get("/", controller.getKolcsonzesek);
router.get("/:id", controller.getKolcsonzesById);
router.get("/ugyfel/:nev", controller.getKolcsonzesByUgyfel);
router.post("/", controller.createKolcsonzes);

module.exports = router;
