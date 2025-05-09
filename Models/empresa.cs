namespace Music_Store.Models
{
    public static class empresa
    {
        public static List<disco> catalogo;

        public static void InicializarCatalogo()
        {
            catalogo = new List<disco>
            {
                // Álbumes de Bad Bunny
                new disco(1, "X100PRE", "Bad Bunny", "Rimas Music", "Reggaetón", "x100pre.jfif", new List<string>()
                {
                    
                    "NI BIEN NI MAL",
                    "200 Mph",
                    "¿Quien Tu Eres?",
                    "Caro",
                    "Tenemos Que Hablar",
                    "Otra Noche En Miami",
                    "Ser Bichote",
                    "Si Estuviesemos Juntos",
                    "Solo De Mi",
                    "Estamos Bien",
                    "Cuando Perribas",
                    "La Romana",
                    "Como Antes",
                    "RLNDT",
                    "Estamos Bien",
                    "MIA"
                }),
                new disco(2, "OASIS", "Bad Bunny & J Balvin", "Universal Music Latino", "Reggaetón", "oasis.jfif", new List<string>()
                {
                    "MOJAITA",
                    "YO LE LLEGO",
                    "CUIDAO POR AHÍ",
                    "QUE PRETENDES",
                    "LA CANCIÓN",
                    "UN PESO",
                    "ODIO",
                    "COMO UN BEBÉ",
                }),
                new disco(3, "YHLQMDLG", "Bad Bunny", "Rimas Music", "Reggaetón", "yhlqmdlg.jfif", new List<string>()
                {
                    "Si Veo a Tu Mamá",
                    "La Dificil",
                    "Pero Ya No",
                    "La Santa",
                    "Yo Perreo Sola",
                    "Bichiyal",
                    "Solía",
                    "La Zona",
                    "Que Malo",
                    "Vete",
                    "Ignorantes",
                    "A Tu Merced",
                    "Una Vez",
                    "Safaera",
                    "25/8",
                    "Está Cabrón Ser Yo",
                    "Puesto Pa' Guerrial",
                    "P FKN R",
                    "Hablamos Mañana",
                    "<3"
                }),
                new disco(4, "EL ÚLTIMO TOUR DEL MUNDO", "Bad Bunny", "Rimas Music", "Reggaetón", "eutdm.jfif", new List<string>()
                {
                    "EL MUNDO ES MÍO",
                    "TE MUDASTE",
                    "HOY COBRÉ",
                    "MALDITA POBREZA",
                    "LA NOCHE DE ANOCHE",
                    "TE DESEO LO MEJOR",
                    "YO VISTO ASÍ",
                    "HACIENDO QUE ME AMAS",
                    "BOOKER T",
                    "LA DROGA",
                    "DÁKITI",
                    "TRELLAS",
                    "SORRY PAPI",
                    "120",
                    "ANTES QUE SE ACABE",
                    "CANTARES DE NAVIDAD"
                }),
                new disco(5, "Un Verano Sin Ti", "Bad Bunny", "Rimas Music", "Reggaetón", "uvst.jfif", new List<string>()
                {
                    "Moscow Mule",
                    "Después De La Playa",
                    "Me Porto Bonito ",
                    "Tití Me Preguntó",
                    "Un Ratito",
                    "Yo No Soy Celoso",
                    "Tarot",
                    "Neverita",
                    "La Corriente",
                    "Efecto",
                    "Party",
                    "Aguacero",
                    "Enséñame a Bailar",
                    "Ojitos Lindos",
                    "Dos Mil 16",
                    "El Apagón",
                    "Otro Atardecer",
                    "Un Coco",
                    "Andrea",
                    "Me Fui De Vacaciones",
                    "Un Verano Sin Ti",
                    "Agosto",
                    "Callaita"
                }),
                new disco(6, "nadie sabe lo que va a pasar mañana", "Bad Bunny", "Rimas Music", "Reggaetón", "nslqvapm.jfif", new List<string>()
                {
                    "NADIE SABE",
                    "MONACO",
                    "FINA",
                    "HIBIKI",
                    "MR.OCTOBER",
                    "CYBERTRUCK",
                    "VOU 787",
                    "SEDA",
                    "GRACIAS POR NADA",
                    "TELEFONO NUEVO",
                    "BABY NUEVA",
                    "MERCEDES CAROTA",
                    "LOS PITS",
                    "VUELVE CANDY B",
                    "BATICANO",
                    "NO ME QUIERO CASAR",
                    "WHERE SHE GOES",
                    "THUNDER Y LIGHTNING",
                    "PERRO NEGRO",
                    "EUROPA:)",
                    "ACHO PR",
                    "UN PREVIEW"
                }),

                new disco(7, "DEBÍ TIRAR MÁS FOTOS", "Bad Bunny", "Rimas Music", "Reggaetón", "dtmf.jfif", new List<string>()
                {
                    "NUEVAYOL",
                    "VOY A LLEVARTE PA PR",
                    "BAILE INOLVIDABLE",
                    "PERFUMITO NUEVO",
                    "WELTITA",
                    "VELDÁ",
                    "EL CLÚB",
                    "KETU TECRÉ",
                    "BOKETE",
                    "KLOUFRENS",
                    "TURISTA",
                    "CAFÉ CON RON",
                    "PITORRO DE COCO",
                    "LO QUE LE PASÓ A HAWAII",
                    "EOO",
                    "DTMF",
                    "LA MUDANZA"
                }),

                // Álbumes de Tini
                new disco(8, "Quiero Volver", "Tini", "Sony Music Latin", "Pop", "qv.jfif", new List<string>()
                {
                    "Quiero Volver",
                    "Flores",
                    "Princesa",
                    "Like That",
                    "Por Qué Te Vas",
                    "Waves",
                    "Consejo de Amor",
                    "Never Ready",
                    "Love Is Love",
                    "Te Quiero Más",
                    "Respirar"
                }),
                new disco(9, "TINI TINI TINI", "Tini", "Sony Music Latin", "Pop", "tinitinitini.jfif", new List<string>()
                {
                    "Un Beso en Madrid",
                    "Fresa",
                    "Si Tú Supieras",
                    "Tuyo",
                    "Te Olvidaré",
                    "Acércate",
                    "Playa",
                    "Ella Dice",
                    "Duele",
                    "Recuerdo",
                    "Oye",
                    "Diciembre",
                    "Suéltate el Pelo",
                    "22"
                }),
                new disco(10, "Cupido", "Tini", "Sony Music Latin", "Pop", "cupido.jfif", new List<string>()
                {
                    "Cupido",
                    "Te Pido",
                    "Muñecas",
                    "El Último Beso",
                    "Carne y Hueso",
                    "La Loto",
                    "Las Jordans",
                    "Beso En Las Rocas",
                    "7 Veces",
                    "Fantasi",
                    "Miénteme",
                    "Maldita Foto",
                    "Bar",
                    "La Triple T"
                }),
                new disco (11, "Un Mechón de Pelo", "Tini", "Sony Music Latin", "Pop", "umdp.jfif", new List<string>()
                {
                    "pa",
                    "posta",
                    "miedo",
                    "ni de ti",
                    "ángel",
                    "buenos aires",
                    "tinta 90",
                    "ellas",
                    "bien",
                    "me voy"
                })
            };
        }
    }
}