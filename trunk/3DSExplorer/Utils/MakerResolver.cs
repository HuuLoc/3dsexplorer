﻿namespace _3DSExplorer
{
    public static class MakerResolver
    {
        public static string Resolve(char[] chars)
        {
            var makerCode = chars[0].ToString() + chars[1];
            switch (makerCode)
            {
                case "00": return "Nintendo";
                case "01": return "Nintendo";

                case "0B": return "Coconuts Japan";
                case "0C": return "Coconuts Japan/G.X.Media";
                case "0D": return "Micronet?";
                case "0E": return "Technos";
                case "0F": return "Mebio Software";
                case "0G": return "Shouei System";
                case "0H": return "Starfish";
                case "0J": return "Mitsui Fudosan/Dentsu";
                case "0L": return "Warashi Inc.";
                case "0N": return "Nowpro";
                case "0P": return "Game Village";
                case "10": return "?????????????";
                case "12": return "Infocom";
                case "13": return "Electronic Arts Japan";
                case "15": return "Cobra Team";
                case "16": return "Human/Field";
                case "17": return "KOEI";
                case "18": return "Hudson Soft";
                case "19": return "S.C.P.";
                case "1A": return "Yanoman";
                case "1C": return "Tecmo Products";
                case "1D": return "Japan Glary Business";
                case "1E": return "Forum/OpenSystem";
                case "1F": return "Virgin Games";
                case "1G": return "SMDE";
                case "1J": return "Daikokudenki";
                case "1P": return "Creatures Inc.";
                case "1Q": return "TDK Deep Impresion";
                case "20": return "Destination Software, KSS";
                case "21": return "Sunsoft/Tokai Engineering??";
                case "22": return "POW, VR 1 Japan??";
                case "23": return "Micro World";
                case "25": return "San-X";
                case "26": return "Enix";
                case "27": return "Loriciel/Electro Brain";
                case "28": return "Kemco Japan";
                case "29": return "Seta";
                case "2A": return "Culture Brain";
                case "2C": return "Palsoft";
                case "2D": return "Visit Co.,Ltd.";
                case "2E": return "Intec";
                case "2F": return "System Sacom";
                case "2G": return "Poppo";
                case "2H": return "Ubisoft Japan";
                case "2J": return "Media Works";
                case "2K": return "NEC InterChannel";
                case "2L": return "Tam";
                case "2M": return "Jordan";
                case "2N": return "Smilesoft ???, Rocket ???";
                case "2Q": return "Mediakite";
                case "30": return "Viacom";
                case "31": return "Carrozzeria";
                case "32": return "Dynamic";
                // case "33": return "NOT A COMPANY!";
                case "34": return "Magifact";
                case "35": return "Hect";
                case "36": return "Codemasters";
                case "37": return "Taito/GAGA Communications";
                case "38": return "Laguna";
                case "39": return "Telstar Fun & Games, Event/Taito";
                case "3B": return "Arcade Zone Ltd";
                case "3C": return "Entertainment International/Empire Software?";
                case "3D": return "Loriciel";
                case "3E": return "Gremlin Graphics";
                case "3F": return "K.Amusement Leasing Co.";
                case "40": return "Seika Corp.";
                case "41": return "Ubi Soft Entertainment";
                case "42": return "Sunsoft US?";
                case "44": return "Life Fitness";
                case "46": return "System 3";
                case "47": return "Spectrum Holobyte";
                case "49": return "IREM";
                case "4B": return "Raya Systems";
                case "4C": return "Renovation Products";
                case "4D": return "Malibu Games";
                case "4F": return "Eidos (was U.S. Gold <=1995)";
                case "4G": return "Playmates Interactive?";
                case "4J": return "Fox Interactive";
                case "4K": return "Time Warner Interactive";
                case "4Q": return "Disney Interactive";
                case "4S": return "Black Pearl";
                case "4U": return "Advanced Productions";
                case "4X": return "GT Interactive";
                case "4Y": return "RARE?";
                case "4Z": return "Crave Entertainment";
                case "50": return "Absolute Entertainment";
                case "51": return "Acclaim";
                case "52": return "Activision";
                case "53": return "American Sammy";
                case "54": return "Take 2 Interactive (before it was GameTek)";
                case "55": return "Hi Tech";
                case "56": return "LJN LTD.";
                case "58": return "Mattel";
                case "5A": return "Mindscape, Red Orb Entertainment?";
                case "5B": return "Romstar";
                case "5C": return "Taxan";
                case "5D": return "Midway (before it was Tradewest)";
                case "5F": return "American Softworks";
                case "5G": return "Majesco Sales Inc";
                case "5H": return "3DO";
                case "5K": return "Hasbro";
                case "5L": return "NewKidCo";
                case "5M": return "Telegames";
                case "5N": return "Metro3D";
                case "5P": return "Vatical Entertainment";
                case "5Q": return "LEGO Media";
                case "5S": return "Xicat Interactive";
                case "5T": return "Cryo Interactive";
                case "5W": return "Red Storm Entertainment";
                case "5X": return "Microids";
                case "5Z": return "Conspiracy/Swing";
                case "60": return "Titus";
                case "61": return "Virgin Interactive";
                case "62": return "Maxis";
                case "64": return "LucasArts Entertainment";
                case "67": return "Ocean";
                case "69": return "Electronic Arts";
                case "6B": return "Laser Beam";
                case "6E": return "Elite Systems";
                case "6F": return "Electro Brain";
                case "6G": return "The Learning Company";
                case "6H": return "BBC";
                case "6J": return "Software 2000";
                case "6L": return "BAM! Entertainment";
                case "6M": return "Studio 3";
                case "6Q": return "Classified Games";
                case "6S": return "TDK Mediactive";
                case "6U": return "DreamCatcher";
                case "6V": return "JoWood Produtions";
                case "6W": return "SEGA";
                case "6X": return "Wannado Edition";
                case "6Y": return "LSP";
                case "6Z": return "ITE Media";
                case "70": return "Infogrames";
                case "71": return "Interplay";
                case "72": return "JVC";
                case "73": return "Parker Brothers";
                case "75": return "Sales Curve";
                case "78": return "THQ";
                case "79": return "Accolade";
                case "7A": return "Triffix Entertainment";
                case "7C": return "Microprose Software";
                case "7D": return "Universal Interactive, Sierra, Simon & Schuster?";
                case "7F": return "Kemco";
                case "7G": return "Rage Software";
                case "7H": return "Encore";
                case "7J": return "Zoo";
                case "7K": return "BVM";
                case "7L": return "Simon & Schuster Interactive";
                case "7M": return "Asmik Ace Entertainment Inc./AIA";
                case "7N": return "Empire Interactive?";
                case "7Q": return "Jester Interactive";
                case "7T": return "Scholastic";
                case "7U": return "Ignition Entertainment";
                case "7W": return "Stadlbauer";
                case "80": return "Misawa";
                case "81": return "Teichiku";
                case "82": return "Namco Ltd.";
                case "83": return "LOZC";
                case "84": return "KOEI";
                case "86": return "Tokuma Shoten Intermedia";
                case "87": return "Tsukuda Original";
                case "88": return "DATAM-Polystar";
                case "8B": return "Bulletproof Software";
                case "8C": return "Vic Tokai Inc.";
                case "8E": return "Character Soft";
                case "8F": return "I'Max";
                case "8G": return "Saurus";
                case "8J": return "General Entertainment";
                case "8N": return "Success";
                case "8P": return "SEGA Japan";
                case "90": return "Takara Amusement";
                case "91": return "Chun Soft";
                case "92": return "Video System, McO'River???";
                case "93": return "BEC";
                case "95": return "Varie";
                case "96": return "Yonezawa/S'pal";
                case "97": return "Kaneko";
                case "99": return "Victor Interactive Software, Pack in Video";
                case "9A": return "Nichibutsu/Nihon Bussan";
                case "9B": return "Tecmo";
                case "9C": return "Imagineer";
                case "9F": return "Nova";
                case "9G": return "Den'Z";
                case "9H": return "Bottom Up";
                case "9J": return "TGL";
                case "9L": return "Hasbro Japan?";
                case "9N": return "Marvelous Entertainment";
                case "9P": return "Keynet Inc.";
                case "9Q": return "Hands-On Entertainment";
                case "A0": return "Telenet";
                case "A1": return "Hori";
                case "A4": return "Konami";
                case "A5": return "K.Amusement Leasing Co.";
                case "A6": return "Kawada";
                case "A7": return "Takara";
                case "A9": return "Technos Japan Corp.";
                case "AA": return "JVC, Victor Musical Indutries";
                case "AC": return "Toei Animation";
                case "AD": return "Toho";
                case "AF": return "Namco";
                case "AG": return "Media Rings Corporation";
                case "AH": return "J-Wing";
                case "AJ": return "Pioneer LDC";
                case "AK": return "KID";
                case "AL": return "Mediafactory";
                case "AP": return "Infogrames Hudson";
                case "AQ": return "Kiratto. Ludic Inc";
                case "B0": return "Acclaim Japan";
                case "B1": return "ASCII (was Nexoft?)";
                case "B2": return "Bandai";
                case "B4": return "Enix";
                case "B6": return "HAL Laboratory";
                case "B7": return "SNK";
                case "B9": return "Pony Canyon";
                case "BA": return "Culture Brain";
                case "BB": return "Sunsoft";
                case "BC": return "Toshiba EMI";
                case "BD": return "Sony Imagesoft";
                case "BF": return "Sammy";
                case "BG": return "Magical";
                case "BH": return "Visco";
                case "BJ": return "Compile ";
                case "BL": return "MTO Inc.";
                case "BN": return "Sunrise Interactive";
                case "BP": return "Global A Entertainment";
                case "BQ": return "Fuuki";
                case "C0": return "Taito";
                case "C2": return "Kemco";
                case "C3": return "Square";
                case "C4": return "Tokuma Shoten";
                case "C5": return "Data East";
                case "C6": return "Tonkin House	(was Tokyo Shoseki)";
                case "C8": return "Koei";
                case "CA": return "Konami/Ultra/Palcom";
                case "CB": return "NTVIC/VAP";
                case "CC": return "Use Co.,Ltd.";
                case "CD": return "Meldac";
                case "CE": return "Pony Canyon";
                case "CF": return "Angel, Sotsu Agency/Sunrise";
                case "CJ": return "Boss";
                case "CG": return "Yumedia/Aroma Co., Ltd";
                case "CK": return "Axela/Crea-Tech?";
                case "CL": return "Sekaibunka-Sha, Sumire kobo?, Marigul Management Inc.?";
                case "CM": return "Konami Computer Entertainment Osaka";
                case "CP": return "Enterbrain";
                case "D0": return "Taito/Disco";
                case "D1": return "Sofel";
                case "D2": return "Quest, Bothtec";
                case "D3": return "Sigma, ?????";
                case "D4": return "Ask Kodansha";
                case "D6": return "Naxat";
                case "D7": return "Copya System";
                case "D8": return "Capcom Co., Ltd.";
                case "D9": return "Banpresto";
                case "DA": return "TOMY";
                case "DB": return "LJN Japan";
                case "DD": return "NCS";
                case "DE": return "Human Entertainment";
                case "DF": return "Altron";
                case "DG": return "Jaleco???";
                case "DH": return "Gaps Inc.";
                case "DL": return "????";
                case "DN": return "Elf";
                case "E0": return "Jaleco";
                case "E1": return "????";
                case "E2": return "Yutaka";
                case "E3": return "Varie";
                case "E4": return "T&ESoft";
                case "E5": return "Epoch";
                case "E7": return "Athena";
                case "E8": return "Asmik";
                case "E9": return "Natsume";
                case "EA": return "King Records";
                case "EB": return "Atlus";
                case "EC": return "Epic/Sony Records";
                case "EE": return "IGS";
                case "EG": return "Chatnoir";
                case "EH": return "Right Stuff";
                case "EJ": return "????";
                case "EL": return "Spike";
                case "EM": return "Konami Computer Entertainment Tokyo";
                case "EN": return "Alphadream Corporation";
                case "F0": return "A Wave";
                case "F1": return "Motown Software";
                case "F2": return "Left Field Entertainment";
                case "F3": return "Extreme Ent. Grp.";
                case "F4": return "TecMagik";
                case "F9": return "Cybersoft";
                case "FB": return "Psygnosis";
                case "FE": return "Davidson/Western Tech.";
                case "G1": return "PCCW Japan";
                case "G4": return "KiKi Co Ltd";
                case "G5": return "Open Sesame Inc???";
                case "G6": return "Sims";
                case "G7": return "Broccoli";
                case "G8": return "Avex";
                case "G9": return "D3 Publisher";
                case "GB": return "Konami Computer Entertainment Japan";
                case "GD": return "Square-Enix";
                case "IH": return "Yojigen";
                default: return string.Empty;
            }
        }
    }
}
