namespace Constantes
{
    /// <summary>
    /// Constantes liées aux types de fichiers (codes de visualisation, libellés et listes
    /// d'extensions par famille de type), portées depuis le fichier WLangage _constantes.wl
    /// (bloc "Constantes des types de fichiers"). La casse d'origine des préfixes
    /// (Ctyp_/CTyp_/CType_) est volontairement conservée telle quelle, sans être
    /// uniformisée, pour rester fidèle à la source.
    /// </summary>
    public static class TypesFichier
    {
        // ********************************************************************************
        // Codes de visualisation
        // ********************************************************************************
        public const int CVisu_Impossible = 0;
        public const int CVisu_Pdf = 1;
        public const int CVisu_Doc = 2;
        public const int CVisu_Xl = 3;
        public const int CVisu_Dessin = 4;
        public const int CVisu_Json = 5;
        public const int CVisu_Html = 6;
        public const int CVisu_Zip = 7;
        public const int CVisu_Lien = 8;
        public const int CVisu_Texte = 9;
        public const int CVisu_XlLibreOf = 10;
        public const int CVisu_DocLibreOf = 11;
        public const int CVisu_Message = 12;
        public const int CVisu_Presentation = 13;

        // ********************************************************************************
        // Libellés associés aux types de documents
        // ********************************************************************************
        public const string C_NomType_Pdf = "Document PDF";
        public const string C_NomType_Img = "Document Image/Dessin";
        public const string C_NomType_Txt = "Document Texte";
        public const string C_NomType_Xls = "Feuilles de calcul (mso)";
        public const string C_NomType_Xlx = "Feuilles de calcul (autres)";
        public const string C_NomType_Doc = "Document Word (mso)";
        public const string C_NomType_Dox = "Document Word (autres)";
        public const string C_NomType_Htm = "Document HTML";
        public const string C_NomType_Jso = "Document JSON";
        public const string C_NomType_Zip = "Fichiers compressés";
        public const string C_NomType_Message = "Messagerie";
        public const string C_NomType_Présentation = "Présentation";

        // ********************************************************************************
        // Listes d'extensions par famille de type (chaînes délimitées par ';')
        // ********************************************************************************
        public const string CTyp_Inconnu = "";
        public const string Ctyp_Pdf = "pdf;fdf;xfdf;";
        public const string Ctyp_Image = "bmp;jpg;jpeg;jpe;jfif;png;gif;tif;tiff;";
        public const string Ctyp_Texte = "txt;wl;md;tex;csv;xml;log;dif;slk;ini;cfg;conf;yaml;yml;toml;bat;sh;sql;nfo;rst;dat;";
        public const string Ctyp_FeuilleExcel = "xls;xlsx;xlsm;xlsb;xlt;xltx;xltm;ods;xla;";
        public const string CTyp_ExcelLibreOffice = "ods;prn;";
        public const string Ctyp_DocWord = "doc;docx;docm;dot;dotx;dotm;rtf;";
        public const string CType_DocLibreOffice = "odt;";
        public const string Ctyp_PageHtml = "html;htm;xhtml;mhtml;asp;aspx;php;jsp;cfm;dhtml;shtml;cshtml;vbhtml;erb;twig;css;js;ts;vue;svelte;";
        public const string Ctyp_Json = "json;jsonl;ndjson;geojson;topojson;har;";
        public const string Ctyp_Zip = "zip;rar;7z;tar;gz;bz2;xz;zipx;iso;cab;lzh;arj;z;lz;zst;tgz;tbz2;txz;";
        public const string CTyp_Lien = "http;";
        public const string CTyp_Message = "msg;";
        public const string CType_Presentation = "pptx;ppt;pps;ppsx;pptm;odp;key";

        // ********************************************************************************
        // Filtres de sélecteur de fichiers (format "Libellé" TAB "Motifs" RC répété),
        // alignés sur les familles ci-dessus. Utilise \t/\r\n en dur plutôt que les
        // constantes TAB/RC de WL.Constantes, afin que cette librairie reste sans
        // dépendance.
        // ********************************************************************************
        public const string CSel_Image =
            "Images" + "\t" + "*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tif;*.tiff;*.webp" + "\r\n" +
            "JPEG" + "\t" + "*.jpg;*.jpeg" + "\r\n" +
            "PNG" + "\t" + "*.png" + "\r\n" +
            "Bitmap" + "\t" + "*.bmp" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_Texte =
            "Fichiers texte" + "\t" + "*.txt;*.csv;*.log" + "\r\n" +
            "Texte" + "\t" + "*.txt" + "\r\n" +
            "CSV" + "\t" + "*.csv" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_Word =
            "Documents Word" + "\t" + "*.doc;*.docx" + "\r\n" +
            "Word ancien format" + "\t" + "*.doc" + "\r\n" +
            "Word" + "\t" + "*.docx" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_Excel =
            "Classeurs Excel" + "\t" + "*.xls;*.xlsx;*.xlsm;*.xlsb" + "\r\n" +
            "Excel ancien format" + "\t" + "*.xls" + "\r\n" +
            "Excel" + "\t" + "*.xlsx;*.xlsm;*.xlsb" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_Pdf =
            "Documents PDF" + "\t" + "*.pdf" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_CSV =
            "Fichiers CSV" + "\t" + "*.csv" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_XML =
            "Fichiers XML" + "\t" + "*.xml" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_JSON =
            "Fichiers JSON" + "\t" + "*.json" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_HTML =
            "Fichiers HTML" + "\t" + "*.htm;*.html" + "\r\n" +
            "Tous" + "\t" + "*.*";
        // ----------------------------------------
        public const string CSel_Tous =
            "Tous les fichiers" + "\t" + "*.*";
    }
}
