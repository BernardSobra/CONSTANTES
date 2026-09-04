namespace Constantes
{
    /// <summary>
    /// Constantes de ponctuation, de typographie, de signes monétaires et de lettres
    /// accentuées, portées depuis le fichier WLangage _constantes.wl (bloc "Constantes
    /// Windows-1252 (ASCII étendu) — v1.1"). Regroupées ici pour être réutilisables
    /// indépendamment d'un projet particulier (via une référence de projet).
    /// </summary>
    public static class CaracteresSpeciaux
    {
        // ********************************************************************************
        // 1. Ponctuation et opérateurs
        // ********************************************************************************
        public const string C_point = ".";
        public const string C_virgule = ",";
        public const string C_point_virgule = ";";
        public const string C_deux_points = ":";
        public const string C_exclamation = "!";
        public const string C_interrogation = "?";
        public const string C_parenth_on = "(";
        public const string C_parenth_off = ")";
        public const string C_crochet_on = "[";
        public const string C_crochet_off = "]";
        public const string C_accolade_on = "{";
        public const string C_accolade_off = "}";
        public const string C_slash = "/";
        public const string C_backslash = @"\";
        public const string C_pipe = "|";
        public const string C_underscore = "_";
        public const string C_plus = "+";
        public const string C_moins = "-";
        public const string C_egal = "=";
        public const string C_etoile = "*";
        public const string C_superieur = ">";
        public const string C_inferieur = "<";
        public const string C_arobas = "@";
        public const string C_diese = "#";
        public const string C_pourcent = "%";
        public const string C_etcommercial = "&";
        public const string C_espace = " ";

        // ********************************************************************************
        // 2. Guillemets et ponctuation typographique
        // ********************************************************************************
        public const string C_quot_bas = "‚";        // U+201A
        public const string C_quot_g = "‘";           // U+2018
        public const string C_quot_d = "’";           // U+2019
        public const string C_dquot_g = "“";          // U+201C
        public const string C_dquot_d = "”";          // U+201D
        public const string C_guillemet_on = "«";
        public const string C_guillemet_off = "»";
        public const string C_point_milieu = "·";
        public const string C_trois_points = "…";
        public const string C_bullet = "•";
        public const string C_dagger = "†";
        public const string C_dagger_double = "‡";

        // ********************************************************************************
        // 3. Signes monétaires et divers
        // ********************************************************************************
        public const string C_euro = "€";
        public const string C_cent = "¢";
        public const string C_livre = "£";
        public const string C_yen = "¥";
        public const string C_paragraphe = "§";
        public const string C_copyright = "©";
        public const string C_registered = "®";
        public const string C_trademark = "™";
        public const string C_degres = "°";
        public const string C_plus_moins = "±";
        public const string C_multiplication = "×";
        public const string C_division = "÷";
        public const string C_not = "¬";
        public const string C_pipe_cassee = "¦";
        public const string C_pour_mille = "‰";

        // ********************************************************************************
        // 4. Accents isolés et diacritiques
        // ********************************************************************************
        public const string C_accent_grave = "`";
        public const string C_accent_aigue = "´";
        public const string C_circonflexe = "^";      // ASCII 94
        public const string C_circonf_diacrit = "ˆ";  // U+02C6
        public const string C_diaeresis = "¨";
        public const string C_cedille_seule = "¸";
        public const string C_macron = "¯";
        public const string C_tilde_petite = "˜";

        // ********************************************************************************
        // 5. Lettres accentuées minuscules
        // ********************************************************************************
        public const string C_a_grave = "à";
        public const string C_a_aigue = "á";
        public const string C_a_circ = "â";
        public const string C_a_tilde = "ã";
        public const string C_a_trema = "ä";
        public const string C_a_rond = "å";
        public const string C_a_elié = "æ";
        public const string C_c_cedille = "ç";
        public const string C_e_grave = "è";
        public const string C_e_aigue = "é";
        public const string C_e_circ = "ê";
        public const string C_e_trema = "ë";
        public const string C_i_grave = "ì";
        public const string C_i_aigue = "í";
        public const string C_i_circ = "î";
        public const string C_i_trema = "ï";
        public const string C_n_tilde = "ñ";
        public const string C_o_grave = "ò";
        public const string C_o_aigue = "ó";
        public const string C_o_circ = "ô";
        public const string C_o_tilde = "õ";
        public const string C_o_trema = "ö";
        public const string C_o_barre = "ø";
        public const string C_oelig = "œ";
        public const string C_u_grave = "ù";
        public const string C_u_aigue = "ú";
        public const string C_u_circ = "û";
        public const string C_u_trema = "ü";
        public const string C_y_aigue = "ý";
        public const string C_y_trema = "ÿ";
        public const string C_thorn_min = "þ";
        public const string C_eth_min = "ð";
        public const string C_scaron_min = "š";

        // ********************************************************************************
        // 6. Lettres accentuées majuscules (notation anti-collision)
        // ********************************************************************************
        public const string C_Agrave = "À";
        public const string C_Aaigue = "Á";
        public const string C_Acirc = "Â";
        public const string C_Atilde = "Ã";
        public const string C_Atrema = "Ä";
        public const string C_Arond = "Å";
        public const string C_AElie = "Æ";
        public const string C_Ccedille = "Ç";
        public const string C_Egrave = "È";
        public const string C_Eaigue = "É";
        public const string C_Ecirc = "Ê";
        public const string C_Etrema = "Ë";
        public const string C_Igrave = "Ì";
        public const string C_Iaigue = "Í";
        public const string C_Icirc = "Î";
        public const string C_Itrema = "Ï";
        public const string C_Ntilde = "Ñ";
        public const string C_Ograve = "Ò";
        public const string C_Oaigue = "Ó";
        public const string C_Ocirc = "Ô";
        public const string C_Otilde = "Õ";
        public const string C_Otrema = "Ö";
        public const string C_Obarre = "Ø";
        public const string C_OElig_Maj = "Œ";
        public const string C_Ugrave = "Ù";
        public const string C_Uaigue = "Ú";
        public const string C_Ucirc = "Û";
        public const string C_Utrema = "Ü";
        public const string C_Yaigue = "Ý";
        public const string C_Ytrema = "Ÿ";
        public const string C_THORNmaj = "Þ";
        public const string C_ETHmaj = "Ð";
        public const string C_Scaron = "Š";
        public const string C_Zcaron = "Ž";

        // ********************************************************************************
        // 7. Fractions, exposants et ordinaux
        // ********************************************************************************
        public const string C_frac_1_4 = "¼";
        public const string C_frac_1_2 = "½";
        public const string C_frac_3_4 = "¾";
        public const string C_sup_1 = "¹";
        public const string C_sup_2 = "²";
        public const string C_sup_3 = "³";
        public const string C_sup_a = "ª";
        public const string C_sup_o = "º";
        public const string C_micro = "µ";
    }
}
