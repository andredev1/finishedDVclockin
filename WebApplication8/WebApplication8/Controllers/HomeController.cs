﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using Geolocation;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;
using System.Collections;
using Microsoft.CodeAnalysis;
using System.Net;
using CSDetermineOSAndBrowserASPNETCore.UserAgent;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string userAgent, string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string dateTime)
        {
            SqlPart(userAgent, personalIDnumber, latitude, longitude, osName, osVersion, browserName, browserVersion, dateTime);


            return View();
        }

        public IActionResult About(string userAgent, string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string dateTime)
        {
            SqlPart( userAgent,  personalIDnumber,  latitude,  longitude,  osName,  osVersion,  browserName,  browserVersion,  dateTime);
            return RedirectToAction("Contact", "Home");
        }
        public void SqlPart(string userAgent, string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string dateTime)
        {

            if (string.IsNullOrEmpty(userAgent))
            {
                userAgent = Request.Headers["User-Agent"];
            }

            ViewBag.userAgent = userAgent;

            UserAgent ua = new UserAgent(userAgent);

            var aa = ua.Browser;
            browserName = ua.Browser.Name;
            browserVersion = ua.Browser.Name;
            osVersion = ua.OS.Version;
            osName = ua.OS.Name;

            string ipAddress = Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();

            string ID = personalIDnumber;
            string connectionstring = "Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_latitude,fld_longitude,fld_dateTime) values('', '', '" + personalIDnumber + "', '" + osName + "', '" + osVersion + "', '" + browserName + "', '" + browserVersion + "', '" + latitude + "', '" + longitude + "', '" + System.DateTime.Now.AddHours(2) + "'); ", connection);
            com.ExecuteScalar();


            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Maxi', fld_lastName = 'Hobyane' WHERE fld_personalIDnumber = '9508040617089';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Nikkie', fld_lastName = 'Mbhatha' WHERE fld_personalIDnumber = '9501021063084';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Boitumelo', fld_lastName = 'Mufamadi' WHERE fld_personalIDnumber = '9602190461081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Lebogang', fld_lastName = 'Sekgota' WHERE fld_personalIDnumber = '9208290846088';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Noluthando', fld_lastName = 'Mzimkhulu' WHERE fld_personalIDnumber = '9408110298086';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Lethabo', fld_lastName = 'Masogo' WHERE fld_personalIDnumber = '9312020655080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Evelyn', fld_lastName = 'Nyama' WHERE fld_personalIDnumber = '9207040845085';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Nonokazi ', fld_lastName = 'Zulu' WHERE fld_personalIDnumber = '9008260917087';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Mahlodi Elsie', fld_lastName = 'Monyebodi' WHERE fld_personalIDnumber = '9508040617089';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Fiona', fld_lastName = 'Khati' WHERE fld_personalIDnumber = '9810020198084';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Monica', fld_lastName = 'Dube' WHERE fld_personalIDnumber = '9703240482083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Audrey', fld_lastName = 'Ngobeni' WHERE fld_personalIDnumber = '9004210492081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Maureen', fld_lastName = 'Komane' WHERE fld_personalIDnumber = '9304190646080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'pinky', fld_lastName = 'matsitse' WHERE fld_personalIDnumber = '9011050628088';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Madikeledi', fld_lastName = 'Mogotsi' WHERE fld_personalIDnumber = '8903080949081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Liyada', fld_lastName = 'Mukwena' WHERE fld_personalIDnumber = 'FN023166';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Belinda', fld_lastName = 'Ranga' WHERE fld_personalIDnumber = 'DN840476';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Sphosethu ', fld_lastName = 'Sethu' WHERE fld_personalIDnumber = '971102072807';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Tandaza', fld_lastName = 'Benge' WHERE fld_personalIDnumber = '9206130564083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Daurell', fld_lastName = 'Hufke' WHERE fld_personalIDnumber = '9510080087082';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Deonè', fld_lastName = 'Petersen' WHERE fld_personalIDnumber = '8201140229085';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Bronique ', fld_lastName = 'Solomons ' WHERE fld_personalIDnumber = '9801060151083 ';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Charlotte Kanyiswa ', fld_lastName = 'Mbekwa' WHERE fld_personalIDnumber = '8312221070080';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'Michelle', fld_lastName = 'Mpofu' WHERE fld_personalIDnumber = '9712131172083';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET fld_firstName = 'ayanda', fld_lastName = 'cebeni' WHERE fld_personalIDnumber = '8912220865081';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET [fld_longitude] = (SELECT  top 1 [fld_longitude] FROM[tbl_ClockIn] WHERE[fld_latitude] != '' ORDER BY[fld_dateTime] desc) WHERE[fld_longitude] = ''; ", connection);
            com.ExecuteScalar();

            com = new SqlCommand("UPDATE tbl_ClockIn SET [fld_latitude] = (SELECT  top 1 [fld_latitude] FROM[tbl_ClockIn] WHERE[fld_latitude] != '' ORDER BY[fld_dateTime] desc) WHERE[fld_latitude] = ''; ", connection);
            com.ExecuteScalar();

            com = new SqlCommand("DELETE FROM tbl_ClockIn WHERE fld_personalIDnumber ='';", connection);
            com.ExecuteScalar();

            com = new SqlCommand("DELETE FROM tbl_ClockIn WHERE fld_personalIDnumber is null;", connection);
            com.ExecuteScalar();
            
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
