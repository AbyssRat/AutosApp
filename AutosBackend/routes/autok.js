import express from "express";
import router from "express";
import controller from "../controllers/autokController.js";


Autorouter.get("/", controller.getAutok);
Autorouter.get("/:rendszam", controller.getAutoByRendszam);

export default Autorouter;
