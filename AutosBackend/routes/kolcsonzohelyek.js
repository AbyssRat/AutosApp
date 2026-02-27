const express = require("express");
const router = express.Router();
const controller = require("../controllers/kolcsonzoController");

router.get("/", controller.getKolcsonzohelyek);
router.get("/:id", controller.getKolcsonzoById);

module.exports = router;
