using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TynaHra
{
    public static class CodesDatabase
    {

        public static Dictionary<string, string> db = new()
        {
            {
                "help",
                @"<p>Ahoj, vítej ve hře.</p><p>Tvým úkolem je dostat se až na konec! Pomohou ti k tomu nápovědy,
				které se zde objeví po zadání správného kódu. Jen to zkus (až toto dočteš), první kód je
				<strong>start</strong>.</p>
                <p>Nezáleží na velikosti písmen (<strong>START</strong> je také ok), počet špatně zadaných
                kódů je neomezený a potřebuješ-li se vrátit sem, napiš <strong>help</strong>
			    </p>
                <p>Hodit se ti budou mobilní mapy!</p>
                <p>Hodně zdaru!</p>"
            },
            { "start", @"<p class=""text-lg font-bold"">Start</p>
                 <p>Až bus tě vysadí, tři tečky ti poradí: <strong>723 . . . 001</strong>.</p> " },
            {
                "103",
                @"<p class=""text-lg  font-bold"">103</p>
                <p> Pro kola i chodce, marš po ní do kopce po sto dvanáctce, ale jen krátce. </ p >
                <p> Zaboč prudce hop a skok - přes potok.</ p >
                 <p> V krytu břečťanu hledej šestimístnou záhadu.</p> "
            },
            { "515855", @"<p class=""text-lg font-bold"">515855</p>
                 <p> Pokračuj Nad dráhou, až kde se Pod akát lomí, vydej se stezkou mezi stromy.</p>
                 <p>""Dlážděnou"" zkus, až ujdeš kus.</p>
                 <p>Hledej patník na něm kříž pohleď na něj trochu blíž. </p>" },
            { "e7c2", @"<p class=""text-lg font-bold"">e7c2</p>Gépées a dvojitý pařez 50.0147648N, 14.3817151E" },
            { "hlf", @"<p class=""text-lg font-bold"">hlf</p>
                <p>Dojdi na vyhlídku, kde tři duby drží hlídku. </p>
                <p>Časem se vyhlídky mění z téhle už moc vidět není.</p>
                <p>Hledej barák kostkový, číslo popisné ti napoví. 🗺️</p>" },
            { "221/39", @"<p class=""text-lg font-bold"">221/39</p>
                <p>Pod akáty téměř v pravém 📐 přišla pošta. ✉️ </p>" },
             { "sl1z", @"<p class=""text-lg font-bold"">sl1z</p>
                <p>Pokračuj po 112 dokud jí řeka (a A1) nezastaví.</p>
                <p>Centrum, Radotín, Hlubočepy a ???  ti napoví.</p>" },
            { "zbraslav", @"<p class=""text-lg font-bold"">Zbraslav</p>
                <p>Cíl!</p>
                <p>Téměř... Už jen pár kroků směr poslední kód, na Louce se občerstvíme, přepni na zábavní mód!</p>
                <p>Gratulát!</p>" },
        };

        public static (bool, string) GetHtmlForCode(string code)
        {
            string html;
            try
            {
                html = db[code.ToLower().Trim()];
                return (true, html);
            }
            catch (KeyNotFoundException ex)
            {
                return (false, "");
            }
        }
        static string EmptyHtml { get; set; } = "Zadej kód 👆 a odmáčkni to 👍";
        static string WrongHtml { get; set; } = "🤦‍♂️ Tento kód není platný zkus to jinak!";
        public static string EmptyOrWrongCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return EmptyHtml;
            return WrongHtml;

        }

    }
}
