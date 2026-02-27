import express from "express";
import router from "express";
import controller from "../controllers/kolcsonzesekController.js";

Kolcsonzesekrouter.get("/", controller.getKolcsonzesek);
Kolcsonzesekrouter.get("/:id", controller.getKolcsonzesById);
Kolcsonzesekrouter.get("/ugyfel/:nev", controller.getKolcsonzesByUgyfel);
Kolcsonzesekrouter.post("/", controller.createKolcsonzes);

export default Kolcsonzesekrouter;
