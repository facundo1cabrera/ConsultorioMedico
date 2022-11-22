using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsultorioMedico.Controllers
{
    [Route("/")]

    public class LoginController : Controller
    {
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("usaurio", "");
            return View();
        }
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("Login-error")]
        public IActionResult LoginError()
        {

            ViewBag.Error = "You are not log in";
            return View("Login");
        }
        [HttpPost]
        [Route("Login-error")]
        public IActionResult LoginError(string usuario)
        {
            return this.Login(usuario);
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string usuario)
        {
            if (this.UsuarioCorrecto(usuario))
            {
                HttpContext.Session.SetString("usuario", usuario);
                return Redirect("/estudios");
            }
            else
            {
                ViewBag.Error = "Your user is not on the list. Please call your head office.";
            }
            return View();
        }

        public bool UsuarioCorrecto(string nombre)
        {
            List<string> lista = new List<string>();
            lista.Add("admin");
            lista.Add("cpworld");
            lista.Add("maya");
            lista.Add("1ALGERIA");
            lista.Add("2AMERICAN SAMOA");
            lista.Add("3ANGOLA");
            lista.Add("4ANGUILLA");
            lista.Add("5ARGENTINA");
            lista.Add("6ARMENIA");
            lista.Add("7ARUBA");
            lista.Add("8AUSTRALIA");
            lista.Add("9AUSTRIA");
            lista.Add("10AZERBAIJAN");
            lista.Add("11BAHAMAS");
            lista.Add("12BAHRAIN");
            lista.Add("13BANGLADESH");
            lista.Add("14BARBADOS");
            lista.Add("15BELARUS");
            lista.Add("Pa#@fps2019");
            lista.Add("17BELIZE");
            lista.Add("18BENIN");
            lista.Add("19BERMUDA");
            lista.Add("20BOLIVIA");
            lista.Add("21BOSNIA AND HERZEGOVINA");
            lista.Add("22BOTSWANA");
            lista.Add("23BRAZIL");
            lista.Add("24BULGARIA");
            lista.Add("25BURKINA FASO");
            lista.Add("26BURUNDI");
            lista.Add("27CAMBODIA");
            lista.Add("28CAMEROON");
            lista.Add("29CANADA");
            lista.Add("30CAYMAN ISLANDS");
            lista.Add("32CENTRAL AFRICA");
            lista.Add("33CHILE");
            lista.Add("34CHINA");
            lista.Add("35COLOMBIA");
            lista.Add("36CONGO");
            lista.Add("37COSTA RICA");
            lista.Add("38COTE D'IVOIRE");
            lista.Add("39CROATIA");
            lista.Add("40CUBA");
            lista.Add("41CURACAO");
            lista.Add("42CYPRUS");
            lista.Add("43CZECH REPUBLIC");
            lista.Add("44DEMOCRATIC REPUBLIC OF CONGO");
            lista.Add("45DENMARK");
            lista.Add("46DJIBOUTI");
            lista.Add("47DOMINICA");
            lista.Add("48DOMINICAN REPUBLIC");
            lista.Add("49ECUADOR");
            lista.Add("50EGYPT");
            lista.Add("51EL SALVADOR");
            lista.Add("52ESTONIA");
            lista.Add("53ETHIOPIA");
            lista.Add("54FIJI");
            lista.Add("55FINLAND");
            lista.Add("56FRANCE");
            lista.Add("57FRENCH GUIANA");
            lista.Add("58FRENCH POLYNESIA");
            lista.Add("59GABON");
            lista.Add("60GAMBIA");
            lista.Add("61GEORGIA");
            lista.Add("GR2%34#BLOCK07");
            lista.Add("63GHANA");
            lista.Add("631GHANA");
            lista.Add("64GREECE");
            lista.Add("65GRENADA");
            lista.Add("66GUADELOUPE");
            lista.Add("67GUAM");
            lista.Add("68GUATEMALA");
            lista.Add("69GUINEA");
            lista.Add("70GUYANA");
            lista.Add("71HAITI");
            lista.Add("72HONDURAS");
            lista.Add("73HONG KONG");
            lista.Add("74HUNGARY");
            lista.Add("75ICELAND");
            lista.Add("76INDIA");
            lista.Add("77INDONESIA");
            lista.Add("78IRAN");
            lista.Add("79IRAQ");
            lista.Add("IR%34#BLOCK04");
            lista.Add("ISRAEL81@2019");
            lista.Add("82ITALY");
            lista.Add("83JAMAICA");
            lista.Add("84JAPAN");
            lista.Add("85JORDAN");
            lista.Add("86KENYA");
            lista.Add("87KIRIBATI");
            lista.Add("88KOREA");
            lista.Add("89KUWAIT");
            lista.Add("90LATVIA");
            lista.Add("91LEBANON");
            lista.Add("92LESOTHO");
            lista.Add("93LIBERIA");
            lista.Add("94LIBYA");
            lista.Add("95LITHUANIA");
            lista.Add("96LUXEMBOURG");
            lista.Add("97MACAO");
            lista.Add("98MACEDONIA");
            lista.Add("99MADAGASCAR");
            lista.Add("100MALAYSIA");
            lista.Add("101MALDIVES");
            lista.Add("102MALI");
            lista.Add("103MALTA");
            lista.Add("104MARIANA ISLANDS");
            lista.Add("105MARTINIQUE");
            lista.Add("106MAURITANIA");
            lista.Add("107MAURITIUS");
            lista.Add("108MEXICO");
            lista.Add("109MONSERRAT");
            lista.Add("110MOROCCO");
            lista.Add("111MOZAMBIQUE");
            lista.Add("112MYANMAR");
            lista.Add("113NAMIBIA");
            lista.Add("114NEPAL");
            lista.Add("115NETHERLANDS");
            lista.Add("116NEVIS");
            lista.Add("117NEW ZEALAND");
            lista.Add("118NICARAGUA");
            lista.Add("119NIGER");
            lista.Add("120NIGERIA");
            lista.Add("121NORWAY");
            lista.Add("122OMAN");
            lista.Add("123PAKISTAN");
            lista.Add("124PALAU");
            lista.Add("125PANAMA");
            lista.Add("126PAPUA NEW GUINEA");
            lista.Add("127PARAGUAY");
            lista.Add("128PERU");
            lista.Add("129PHILIPPINES");
            lista.Add("130POLAND");
            lista.Add("134PORTUGAL#131");
            lista.Add("132PUERTO RICO");
            lista.Add("134ROMANIA");
            lista.Add("135RUSSIA");
            lista.Add("136RWANDA");
            lista.Add("137SAUDI ARABIA");
            lista.Add("138SENEGAL");
            lista.Add("139SERBIA");
            lista.Add("140SEYCHELLES");
            lista.Add("141SIERRA LEONE");
            lista.Add("142SINGAPORE");
            lista.Add("143SLOVAKIA");
            lista.Add("144SLOVENIA");
            lista.Add("145SOUTH AFRICA");
            lista.Add("146SPAIN");
            lista.Add("147SRI LANKA");
            lista.Add("148ST BARTHELEMY");
            lista.Add("149ST KITTS");
            lista.Add("150ST LUCIA");
            lista.Add("151ST MAARTEN");
            lista.Add("152ST VINCENT");
            lista.Add("153SUDAN");
            lista.Add("154SURINAME");
            lista.Add("155SWAZILAND");
            lista.Add("156SWEDEN");
            lista.Add("157SWITZERLAND");
            lista.Add("158SYRIA");
            lista.Add("159TAIWAN");
            lista.Add("160TANZANIA");
            lista.Add("161THAILAND");
            lista.Add("162TOGO");
            lista.Add("163TRINIDAD");
            lista.Add("1631TRINIDAD");
            lista.Add("164TUNISIA");
            lista.Add("165TURKEY");
            lista.Add("166UGANDA");
            lista.Add("167UKRAINE");
            lista.Add("168UNITED ARAB EMIRATES");
            lista.Add("169UNITED KINGDOM");
            lista.Add("170UNITED STATES");
            lista.Add("171URUGUAY");
            lista.Add("172VENEZUELA");
            lista.Add("173VIETNAM");
            lista.Add("174VIRGIN ISLANDS, BRITISH");
            lista.Add("175VIRGIN ISLANDS, US");
            lista.Add("176YEMEN");
            lista.Add("177ZAMBIA");
            lista.Add("178ZIMBABWE");
            lista.Add("Franky");
            lista.Add("piyush");
            lista.Add("piyush12");
            lista.Add("administrator");
            lista.Add("Franky Van");
            lista.Add("KOREA");
            lista.Add("tomas@fpsprague.com");
            lista.Add("179COOK ISLAND");
            lista.Add("180FUTUNA ISLAND");
            lista.Add("181HAWAII");
            lista.Add("182NEW CALEDONIA");
            lista.Add("183NIUE");
            lista.Add("184SOLOMON ISLAND");
            lista.Add("185TAHITI");
            lista.Add("186TONGA");
            lista.Add("187TUVALU");
            lista.Add("188VANUATU");
            lista.Add("189WALLIS ISLAND");
            lista.Add("190GERMAN SAMOA");
            lista.Add("191CANARY ISLANDS");
            lista.Add("192SCOTLAND");
            lista.Add("193LUXEMBURG");
            lista.Add("194KAZAKISTAN");
            lista.Add("195GREENLAND");
            lista.Add("fpsprague1");
            lista.Add("HONGKONG");
            lista.Add("Scott");
            lista.Add("Scott1");
            lista.Add("Mike Hayes");
            lista.Add("HONGKONG1");
            lista.Add("gezairiist");
            lista.Add("ling123");
            lista.Add("DENMARK");
            lista.Add("SAFI ZINEB");
            lista.Add("KOREA_1");
            lista.Add("1008MYANMAR");
            lista.Add("IRAQ");
            lista.Add("JORDAN");
            lista.Add("ifsmexico");
            lista.Add("Germany$@3241");
            lista.Add("daniel.dubray@cargo-lines.com");
            lista.Add("KOREA_OP");
            lista.Add("EGYPTNEW");
            lista.Add("icalleja");
            lista.Add("ITALY@82");
            lista.Add("PORTUGAL#123");
            lista.Add("SGHKG");
            lista.Add("SGAUS");
            lista.Add("MALAWI@ICA");


            return lista.Contains(nombre);
        }

    }
}