﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult DeleteRepro()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int reproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO video " + "VALUES (@idVideo, @titulo, @reproducciones, @url)", CommandType.Text, parametros);
            return View("Mensaje");
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("DELETE FROM video "  + "WHERE @idVideo = idVideo", CommandType.Text, parametros);
            return View("Mensaje");
        }
        [HttpPost]
        public ActionResult DeleteRepro(int reproducciones)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            BaseHelper.ejecutarSentencia("DELETE FROM video " + "WHERE @reproducciones = reproducciones", CommandType.Text, parametros);
            return View("Mensaje");
        }
        [HttpPost]
        public ActionResult Update(int idVideo, string titulo, int reproducciones, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("UPDATE video " + "SET titulo = @titulo, reproducciones = @reproducciones, url = @url " +  "WHERE idVideo = @idVideo " , CommandType.Text, parametros);
            return View("Mensaje");
        }
    }
}
