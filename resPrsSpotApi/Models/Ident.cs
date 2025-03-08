namespace resPrsSpotApi.Models
{
    public class Ident
    {
        /// <summary>
        /// Portalsko uporabniško ime (tabela portal.md_uporabniki)
        /// </summary>
        public string? uporabnik { get; set; }
        public string? geslo { get; set; }
        /// <summary>
        /// Šifra storitve servisa
        /// </summary>
        public string? storitev { get; set; }
    }

    public class GetMyModel
    {
        public Ident? ident { get; set; }
        /// <summary>
        /// Davčna številka zastopnika oziroma ustanovitelja poslovnega subjekta
        /// </summary>
        public string? davcna { get; set; }
    }
}
