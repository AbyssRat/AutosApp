const express = require("express");
const router = express.Router();
const controller = require("../controllers/ugyfelekController");

router.get("/", controller.getUgyfelek);
router.get("/:nev", controller.getUgyfelByNev);

module.exports = router;
