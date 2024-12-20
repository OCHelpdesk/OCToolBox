using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oc_toolbox_service.Models
{
    public static class ProductSetV20241209
    {
        public static ProductSet ProductSet = new ProductSet()
        {
            Version = "20241209.1",

            ProductCategories = new ProductCategory[]
            {
                new ProductCategory()
                {
                    id = "BIRD & WILDLIFE",
                    name = "BIRD & WILDLIFE",
                    description = "Bird & Wildlife products",
                    image = "oc/pest/bird & wildlife",
                    subcategories = new string[] {"BATS", "BATS: TRAPS", "BIRDS", "BIRDS: DETERRENTS", "BIRDS: SPIKES", "BIRDS: TRAPS", "SKUNKS", "SKUNKS: TRAPS", "WILDLIFE", "WILDLIFE: EQUIPMENT", "WILDLIFE: EXCLUSION", "WILDLIFE: TRAPS"}
                },
                new ProductCategory()
                {
                    id = "CLEANING PRODUCTS",
                    name = "CLEANING PRODUCTS",
                    description = "Cleaning products and disinfectants",
                    image = "oc/cleaner",
                    subcategories = new string[] {"ACTIZYME", "DISINFECTANT", "FOAM"}
                },
                new ProductCategory()
                {
                    id = "DRAIN MAINTENANCE",
                    name = "DRAIN MAINTENANCE",
                    description = "Drain service products",
                    image = "oc/drain maintenance",
                    subcategories = new string[] {"FOAM"}
                },
                new ProductCategory()
                {
                    id = "EQUIPMENT",
                    name = "EQUIPMENT",
                    description = "Pest control equipment",
                    image = "oc/equipment",
                    subcategories = new string[] { }
                },
                new ProductCategory()
                {
                    id = "INSECTS",
                    name = "INSECTS",
                    description = "Insect products",
                    image = "oc/pest/insect",
                    subcategories = new string[] {"ANTS", "ANTS: BAIT STATION", "BED BUGS", "BED BUGS: AEROSOL", "BED BUGS: BAIT", "BED BUGS: ENCASEMENTS", "BED BUGS: INSECTICIDE", "BED BUGS: MONITORS", "FLIES", "FLIES: BAIT STATION", "FLIES: FLY LIGHTS", "FLIES: GLUEBOARDS", "FLIES: TRAPS", "INSECTS", "INSECTS: BAIT", "INSECTS: BAIT STATION", "INSECTS: GLUEBOARDS", "INSECTS: INSECTICIDE", "INSECTS: MONITORS", "INSECTS: TRAPS", "MOSQUITOES", "MOSQUITOES: GLUEBOARDS", "MOSQUITOES: TRAPS", "SPP", "SPP: MONITORS", "TERMITES", "TERMITES: MONITORS", "TICKS", "WASPS", "WASPS: AEROSOL", "WASPS: EQUIPMENT", "WASPS: INSECTICIDE", "WASPS: TRAPS"}
                },
                new ProductCategory()
                {
                    id = "ODOUR CONTROL",
                    name = "ODOUR CONTROL",
                    description = "Odour control products",
                    image = "oc/odour control",
                    subcategories = new string[] {"ODOUR CONTROL", "ODOUR CONTROL: DISPENSERS"}
                },
                new ProductCategory()
                {
                    id = "OTHERS",
                    name = "OTHERS",
                    description = "Other products",
                    image = "oc/orkinonsite",
                    subcategories = new string[] { }
                },
                new ProductCategory()
                {
                    id = "PPE",
                    name = "PPE",
                    description = "Personal protective equipment",
                    image = "oc/ppe",
                    subcategories = new string[] {"COVERALLS", "GLOVES", "MASKS"}
                },
                new ProductCategory()
                {
                    id = "RODENTS",
                    name = "RODENTS",
                    description = "Rodent products",
                    image = "oc/pest/rodent",
                    subcategories = new string[] {"MICE", "MICE: GLUEBOARDS", "MICE: TRAPS", "RATS", "RATS: GLUEBOARDS", "RATS: TRAPS", "RODENTS", "RODENTS: BAIT", "RODENTS: BAIT STATION", "RODENTS: EXCLUSION", "RODENTS: GLUEBOARDS", "RODENTS: RODENTICIDE", "RODENTS: TRAPS"}
                },
                new ProductCategory()
                {
                    id = "SOAK TANK",
                    name = "SOAK TANK",
                    description = "Soak tank products",
                    image = "oc/soak tank",
                    subcategories = new string[] {"CHEMICAL"}
                },
                new ProductCategory()
                {
                    id = "WASHROOM CARE",
                    name = "WASHROOM CARE",
                    description = "Washroom care products",
                    image = "oc/washroom care",
                    subcategories = new string[] {"AUTOCLEAN", "AUTOCLEAN: DISPENSERS", "AUTOCLEAN: PARTS", "AUTOFLUSH", "AUTOFLUSH: PARTS", "AUTOFOAM", "AUTOFOAM: DISPENSERS", "AUTOFOAM: SOAP", "AUTOFRESH", "AUTOFRESH: DISPENSERS", "CLEANSEAT", "CLEANSEAT: DISPENSERS", "CLEANSEAT: REFILLS", "HAND HYGIENE", "HAND HYGIENE: DISPENSERS", "HAND HYGIENE: SANITIZER", "HAND HYGIENE: SOAP", "HYGIENE", "HYGIENE: BIN", "ODOUR CONTROL", "ODOUR CONTROL: DISPENSERS", "ODOUR CONTROL: REFILLS", "ODOUR CONTROL: URINAL", "PAPER PRODUCTS", "PAPER PRODUCTS: DISPENSERS", "URINAL", "URINAL: DISPENSERS", "WASHROOM CARE", "WASHROOM CARE: DISPENSERS"}
                }
            },

            Products = new Product[]
            {
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BATS: TRAPS",
                    Name = "BAT CONE",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "782119",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: DETERRENTS",
                    Name = "BIRD FLITE 2 1/2\" (NARROW)",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781641",
                    PCPNum = "",
                    UOM = "FT",
                    OrkinUOM = "FT",
                    Price = 6.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: DETERRENTS",
                    Name = "BIRD FLITE 4 1/2\" (WIDE)",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781646",
                    PCPNum = "",
                    UOM = "FT",
                    OrkinUOM = "FT",
                    Price = 7.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: SPIKES",
                    Name = "DURA-SPIKE EXTRA WIDE 8\" X 3\"",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781650",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: SPIKES",
                    Name = "DURA-SPIKE WIDE 5\" X 3\"",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781649",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 23.00,
                    OrkinPrice = 23.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: TRAPS",
                    Name = "KAGE-ALL PIGEON TRAP 36\" X 18\" X 8\"",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781593",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: TRAPS",
                    Name = "PIGEON TRAP WITH SHADE & 3.78L WATER BOTTLE",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "791875",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 425.00,
                    OrkinPrice = 425.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: TRAPS",
                    Name = "PIGEON TRAP WITH SHADE, FOOD & WATER PANS",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "791866",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: TRAPS",
                    Name = "SPARROW TRAP WITH FOOD & WATER 36\"X24\"X10\"",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "799111",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 460.00,
                    OrkinPrice = 460.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: BIRDS: TRAPS",
                    Name = "SPARROW TRAP WITH TWO CHAMBER 8\"X12\"X16\"",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "802880",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: SKUNKS: TRAPS",
                    Name = "SKUNK TRAP 30\" X 7\" X 8\"",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794545",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "RACCOON ONE WAY DOOR 10\"X8\"X1\"",
                    Vendor = "RNS TRADING GROUP",
                    ProductId = "799146",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "THE GIANT DESTROYER SUPER GASSER 4/PK (12/CS) PCP#12269",
                    Vendor = "ATLAS CHEMICAL CORP",
                    ProductId = "791972",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "TOMAHAWK EXCLUDER FOR CHIPMUNKS W/ONE WAY DOOR 11\"X3\"X3\"",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "788053",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "TOMAHAWK EXCLUDER FOR SKUNKS W/ONE WAY DOOR 12\"X6\"X6\"",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781740",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "TOMAHAWK EXCLUDER FOR SQUIRRELS W/ONE WAY DOOR 11\"X4\"X4\"",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781739",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE",
                    Name = "TOMAHAWK EXCLUDER W/ONE WAY DOOR 14\"X8\"X8\"",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781741",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: EQUIPMENT",
                    Name = "TOMAHAWK DUAL RELEASE CATCH POLE 5'",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "788048",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: EXCLUSION",
                    Name = "WALL-E-COVER DEEP DRYER COVER - WHITE",
                    Vendor = "MMC DESIGN CONCEPTS INC",
                    ProductId = "806043",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: EXCLUSION",
                    Name = "WALL-E-COVER ROOF VENT COVER - EXPRESSO",
                    Vendor = "MMC DESIGN CONCEPTS INC",
                    ProductId = "806137",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "GOPHER HAWK TRAP (12/CS)",
                    Vendor = "MEISSNER INDUSTRIAL CO INC",
                    ProductId = "883609",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "GOPHER HAWK TRAPPING SET (6/CS)",
                    Vendor = "MEISSNER INDUSTRIAL CO INC",
                    ProductId = "883612",
                    PCPNum = "",
                    UOM = "SET",
                    OrkinUOM = "SET",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "HAVAHART ANIMAL TRAP LARGE 32\"X10\"X12\" 1079",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781610",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "HAVAHART ANIMAL TRAP MEDIUM 24\"X7\"X7\" 1078",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781609",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 89.00,
                    OrkinPrice = 89.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "HAVAHART ANIMAL TRAP SMALL 17.5\"X5.76\"X7.22\" 1025",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "782151",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "HAVAHART ANIMAL TRAP X-SMALL 16\"X6\"X6\" 0745",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781580",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "HAVAHART EASY SET ANIMAL TRAP LARGE 32\"X10\"X12\" 1085",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781612",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "BIRD & WILDLIFE: WILDLIFE: TRAPS",
                    Name = "TALPIRID MOLE TRAP (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "795010",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 48.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: ACTIZYME",
                    Name = "ACTIZYME AEROSOL 16OZ FOAM (12/CS)",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "782708",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: ACTIZYME",
                    Name = "ACTIZYME CONCENTRATE 1G (4/CS)",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "782707",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "ORKIN ZEP SPIRIT II 1L (12/CS)",
                    Vendor = "AMREP",
                    ProductId = "804312",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "ORKIN ZEP SPIRIT II 4L (4/CS)",
                    Vendor = "AMREP",
                    ProductId = "804313",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "PRO 1 SPRAYHEAD FOR ZEP SPIRIT II 1L BOTTLES (180/CS)",
                    Vendor = "AMREP",
                    ProductId = "804322",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 1.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "STERIWIPES 160/EA (18/CS)",
                    Vendor = "TRILLIUM SALES GROUP INC.",
                    ProductId = "804783",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "VIREX II 256 ONE-STEP CLEANER AND DEODORANT (6X946ML)",
                    Vendor = "ROY TURK INDUSTRIAL",
                    ProductId = "781106",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 230.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "ZEP SPIRIT II RTU DETERGENT DISINFECTANT 1L (12/CS)",
                    Vendor = "AMREP",
                    ProductId = "804187",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: DISINFECTANT",
                    Name = "ZEP SPIRIT II RTU DETERGENT DISINFECTANT 4L (4/CS)",
                    Vendor = "AMREP",
                    ProductId = "804190",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CLEANING PRODUCTS: FOAM",
                    Name = "PROFOAM PLATINUM 3.78L (4/CS)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "782076",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 110.00,
                    OrkinPrice = 110.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "DRAIN MAINTENANCE",
                    Name = "GREASEAWAY 3.78L",
                    Vendor = "GENESIS BIOSCIENCES",
                    ProductId = "781411",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 28.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "DRAIN MAINTENANCE: FOAM",
                    Name = "BIOPLUS FOAM & LIQUID FORMULATION (6/CS)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "782077",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "BOSS PRO 320 10L (2.5G) 18V BACKPACK SPRAYER",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "799575",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 750.00,
                    OrkinPrice = 750.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "BOSS PRO 512 18V BACKPACK SPRAYER (4L)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "796542",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "FOAMER SIMPSON 5G",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "804651",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 390.00,
                    OrkinPrice = 390.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "PAX 100 HANDHELD ELECTROSTATIC DISINFECTANT SPRAYER",
                    Vendor = "UNIMANIX INDUSTRIES INC",
                    ProductId = "805398",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 950.00,
                    OrkinPrice = 950.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "SPARTA FLOOR DRAIN BRUSH 3\" DIAMATER",
                    Vendor = "RABCO FOODSERVICES LIMITE",
                    ProductId = "780830",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "SPARTA FLOOR DRAIN HANDLE PLASTIC 36\"",
                    Vendor = "RABCO FOODSERVICES LIMITE",
                    ProductId = "780829",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "SPECTROLINE B-260 BLACK LIGHT W/2X6W BULB & 6V RECH BATTERY",
                    Vendor = "SPECTRONICS CORP",
                    ProductId = "787316",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 270.00,
                    OrkinPrice = 270.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "WEBSTER COB WEB DUSTER HEAD - BLUE (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794901",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "WEBSTER COB WEB DUSTER HEAD - YELLOW (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "781745",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EQUIPMENT",
                    Name = "WEBSTER COB WEB PRO LINE HANDLE 118\" (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "781746",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS",
                    Name = "ONGUARD PRO-PERM INSECT KILLER 3.78L (4/CS) PCP#32333",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800244",
                    PCPNum = "32333",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: ANTS: BAIT STATION",
                    Name = "ANT CAFE BAIT STATION (48/BAG)",
                    Vendor = "INNOVATIVE PEST CONTROL",
                    ProductId = "801850",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: ANTS: BAIT STATION",
                    Name = "ANTS NO MORE BAIT STATIONS (12/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781535",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 46.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: ANTS: BAIT STATION",
                    Name = "TERRO LIQUID ANT BAIT STATION 6/PK (12/CS) T300CAN PCP#30897",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "797942",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS",
                    Name = "BED BUG HOT WATER SOLUBLE BAGS - FRONT LOAD WASHER",
                    Vendor = "HOLLANDER SLEEP & DECOR",
                    ProductId = "789439",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS",
                    Name = "BED BUG HOT WATER SOLUBLE BAGS - TOP LOADER WASHER",
                    Vendor = "HOLLANDER SLEEP & DECOR",
                    ProductId = "782446",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: AEROSOL",
                    Name = "DX13 BED BUG KILLER 400G",
                    Vendor = "DE LABORATORIES INC.",
                    ProductId = "798815",
                    PCPNum = "30973",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: BAIT",
                    Name = "ACTIVCE BED BUG LURE 12/PK (12/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "845710",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT FULL 54X77.5X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885200",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT FULL XL PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793077",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT HOTEL KING 36X82X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885201",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT HOTEL KING PREMIUM (4/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793075",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT QUEEN 60X80X9X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885202",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT QUEEN PREMIUM (6/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793074",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT TWIN 39X77.5\"X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885203",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "BOX SPRING ENCASEMENT TWIN XL PREMIUM (8/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793076",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "CRIB ENCASEMENT PREMIUM (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793107",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "FURNITURE CHAIR ENCASEMENT MD",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793088",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 155.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "FURNITURE LOVE SEAT ENCASEMENT LG (6/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793090",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 230.00,
                    OrkinPrice = 230.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "FURNITURE SOFA BED ENCASEMENT XL (6/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793091",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT CRIB 28X52X7 (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885209",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT FULL PLUS 54X77.5X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885204",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT FULL XL 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792883",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT FULL XL 10-15\" PREMIUM PLUS",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792902",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT FULL XL 16-22\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792888",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT HOTEL KING 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792881",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT HOTEL KING 72X82X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885205",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT KING 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792880",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT KING 10-15\" PREMIUM PLUS",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792890",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT KING 16-22\" PREMIUM PLUS",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792905",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 120.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT KING 78X80X9\"-15\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885206",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT QUEEN 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792878",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT QUEEN 10-15\" PREMIUM PLUS",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792889",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT QUEEN 16-22\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792884",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT QUEEN 60X80X9\"-15\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885207",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT TWIN PLUS 39X77.5X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885208",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT TWIN XL 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792882",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT TWIN XL 10-15\" PREMIUM PLUS",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792900",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "MATTRESS ENCASEMENT TWIN XL 16-22\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792887",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "PILLOW ENCASEMENT KING (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793079",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "PILLOW ENCASEMENT QUEEN (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793078",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: ENCASEMENTS",
                    Name = "ZIPPERED PILLOW COVER QUEEN 2/BG 20X30\" (50/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885210",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: INSECTICIDE",
                    Name = "ONGUARD BED BUG KILLER 400G (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800007",
                    PCPNum = "31515",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BED BUG DEFENDER (12/BX)",
                    Vendor = "INNOVATIVE PEST PRODUCT INC.",
                    ProductId = "784559",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BED BUG MOAT (18/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781283",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BED BUG POWERBAR",
                    Vendor = "BEAPCO",
                    ProductId = "789862",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BED BUG POWERBAR CO2 GENERATOR",
                    Vendor = "BEAPCO",
                    ProductId = "799635",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BED BUG POWERBAR GLUEBOARDS & LURE (4/PK)",
                    Vendor = "BEAPCO",
                    ProductId = "789863",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "BLACKOUT BED BUG TRAP 16/PK (4/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "846837",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "PRO-PEST BED BUG MONITOR PRO BULK BOX 36/PK 4/BX",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789405",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 490.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "PYRAMID PITFALL TRAP 24/PK (6/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "806149",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "SLIDER BED BUG MONITOR (96/CS)",
                    Vendor = "AP&G",
                    ProductId = "789406",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: BED BUGS: MONITORS",
                    Name = "VOLCANO BED BUG TRAP 12/PK (12/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "794237",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: BAIT STATION",
                    Name = "FLY BAIT STATION - GREY (4/BG)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802294",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: BAIT STATION",
                    Name = "FLY BAIT STATION REPLACEMENT TRAY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802378",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 2.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: BAIT STATION",
                    Name = "FLY BAIT STATION STAKE",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802295",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "16\" 36W SLEEVED BL BULB 10/CS 213602-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "786105",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 375.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "16\" 36W STANDARD BL BULB 10/CS 213600-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794380",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "18 LED LONG STRIP 2/PK (8/CS) 500-31808-L18",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806002",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "18W T8 24\" SHATTER RESISTANT BULBS (2/PK) - FOR CHAMELEON FLY LIGHT)",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "883534",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "18W T8 24\" SLEEVED BL BULB 25/CS 213802-51",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794175",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "18W T8 24\" STANDARD BL BULB 25/CS 213800-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794137",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 190.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "20W T12 24\" SLEEVED BULB FOR GILBERT 601 (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789415",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 800.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "20W T12 24\" STANDARD BULB FOR GILBERT 601 (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789419",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 215.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "25W T8 18\" SLEEVED BULB FOR GALAXY LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789420",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "30 LED LONG STRIP2/PK(8/CS) LED300-102 500-330008-L30",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806003",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 68.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "32W T12 18\" STANDARD BL BULB 25/CS 213712-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794443",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 270.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "40W T12 48\" SLEEVED BULB FOR GARDNER (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789425",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 1125.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "40W T12 48\" STANDARD BULB FOR GARDNER (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789423",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 440.00,
                    OrkinPrice = 19.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "BUG ZAPPER LIGHT TRAP 2X40W 48\" BULB - WHITE",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781055",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 595.00,
                    OrkinPrice = 595.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "CATCH TRAY FOR 601T / 601TJ FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "796509",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "CFL 36W 16\" ELECTROSECT SLEEVED BL BULB (10/CS) 213602-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "792645",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "COBRA LED LIGHT - REPLACEMENT COVER",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "883472",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "ENVIROLIGHTS FLYLIGHT JR W/ 2X25W 18\" COATED BULB",
                    Vendor = "DIRECT LINE SALES & SUPPLY",
                    ProductId = "791311",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLY WEB 9W BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781096",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 17.00,
                    OrkinPrice = 17.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYING VENUS 2000GT FLY LIGHT - BLACK",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781333",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 285.00,
                    OrkinPrice = 285.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYING VENUS 2000GT FLY LIGHT - WHITE",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781332",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 280.00,
                    OrkinPrice = 280.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYING VENUS 2002GT FLY LIGHT - BLACK",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781330",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYLITE ELECTRIC GRID TRAP W/2X40W 48\" SHATTERPROOF AG-661S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "846424",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 885.00,
                    OrkinPrice = 885.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYWEB FLY LIGHT",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "780987",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "FLYWEB GLUEBOARDS (10/PK)",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "782236",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 16.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 15W 18\" 25/CS CS-06",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781061",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 15W 18\" SHATTERPROOF 2/PK EL-062S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "782470",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 15W 18\" SHATTERPROOF 25/CS CS-06S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781066",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 20W 24\" SHATTERPROOF 25/CS CS-07S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781067",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 25W 18\" SHATTERPROOF 2/PK EL-082S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781885",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 32W 18\" SHATTERPROOF 25/CS CS-05S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781090",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 600.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 36W T4 16\" (10/CS) EL-12",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "787665",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 17.00,
                    OrkinPrice = 17.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 40W 48\" 2/PK EL-092",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781095",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER BULB 40W 48\" SHATTERPROOF 25/CS CS-09S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781093",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 790.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER WALL SCONCE FLY LIGHT - GOLD",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "780993",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 235.00,
                    OrkinPrice = 235.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER WALL SCONCE FLY LIGHT - WHITE 1X18\" BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781048",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GARDNER WALL SCONCE FLY LIGHT - WHITE 2X18\" BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "799666",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS COBRA LED FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806163",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 395.00,
                    OrkinPrice = 395.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ECLIPSE FLY LIGHT - WHITE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785894",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 220.00,
                    OrkinPrice = 220.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ECLIPSE ULTRA FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794177",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS FLI FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785300",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS FLI LED FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806164",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 365.00,
                    OrkinPrice = 365.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - BLACK (STANDARD BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797410",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 185.00,
                    OrkinPrice = 185.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - BRASS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806159",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 315.00,
                    OrkinPrice = 315.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - BRASS (STANDARD BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797411",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 295.00,
                    OrkinPrice = 295.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - STAINLESS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806157",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 290.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - WHITE (STANDARD BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797413",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME ALPHA GLUE BOARD - WHITE (10/PK)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797419",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 28.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY FLUORESCENT FLY LIGHT - BLACK (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797414",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY FLUORESCENT FLY LIGHT - BRASS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797417",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY FLUORESCENT FLY LIGHT - STAINLESS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797415",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY FLUORESCENT FLY LIGHT - WHITE (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797416",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY LED FLY LIGHT - BLACK",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806006",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 310.00,
                    OrkinPrice = 310.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY LED FLY LIGHT - STAINLESS",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806005",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ILLUME GALAXY LED FLY LIGHT - WHITE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806007",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 290.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS LIBERATOR FLUORESCENT FLY LIGHT - STAINLESS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794444",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 850.00,
                    OrkinPrice = 850.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS LIBERATOR JET FLUORESCENT FLY LIGHT - STAINLESS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796007",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 940.00,
                    OrkinPrice = 940.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ORBIT FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785246",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 485.00,
                    OrkinPrice = 485.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS ORBIT JET FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785299",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 625.00,
                    OrkinPrice = 625.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS SPECTRA COMPACT 230H LED FLY LIGHT (COMES WITH SLEEVED LED STRIPS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "882736",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 385.00,
                    OrkinPrice = 385.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS SPECTRA COMPACT FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789727",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS SPECTRA COMPACT FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785302",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS SPECTRA FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789726",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 550.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS SPECTRA FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785301",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 360.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS VIPER 30 FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796688",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 395.00,
                    OrkinPrice = 395.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GENUS VIPER 60 FLUORESCENT FLY LIGHT (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796687",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GILBERT 601TJ FLY LIGHT",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781319",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 535.00,
                    OrkinPrice = 535.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GILBERT BALLAST FOR 20W UNITS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "800093",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GILBERT BALLAST FOR 40W UNITS (UNITS MADE AFTER NOV 2005)",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "782212",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GLOSTIK INSECT TRAP (6/CS)",
                    Vendor = "AP&G",
                    ProductId = "784689",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GUARD FOR 601TGT / 601GT FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "805808",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GUERRILLA 220 W/2X20W BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781320",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 595.00,
                    OrkinPrice = 595.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "GUERRILLA 220-SC W/2X20W SHATTERCATCH BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "788187",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 600.00,
                    OrkinPrice = 600.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "MANTIS FLY LIGHT",
                    Vendor = "PESTWEST USA LLC",
                    ProductId = "783030",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 280.00,
                    OrkinPrice = 280.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "MANTIS FLY LIGHT GLUEBOARD (6/PK)",
                    Vendor = "PESTWEST USA LLC",
                    ProductId = "781398",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "NIGHT HAWK FLY LIGHT",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781322",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "STARTER FOR GT-180 / WS-85 FLY LIGHTS",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781098",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "STARTER FOR GT-200 / MX-360 / AG-XXX FLY LIGHTS",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781097",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "STICKY LIZARD 601GT-SC W/2X20W SHATTERCATCH BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "847001",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 420.00,
                    OrkinPrice = 420.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "T5 12\" STANDARD BLUE BULB FOR ECLIPSE/ALPHA LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "786104",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 425.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "T5 12\" STANDARD REGULAR BULB FOR ECLIPSE/ALPHA LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "799731",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "T8 18\" SLEEVED BULB FOR FLI/ORBIT/LIBERATOR/VIPER LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789458",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "T8 18\" STANDARD BULB FOR FLI/ORBIT/LIBERATOR/VIPER LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789414",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "THE DON 601T W/2X40W BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781317",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 550.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "TRANSFORMER FOR GILBERT FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "782211",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "UNIVERSAL GLUE BOARD - BLACK 12/PK",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785395",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "UNIVERSAL GLUE BOARD - WHITE 12/PK",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794144",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: FLY LIGHTS",
                    Name = "UNIVERSAL GLUE BOARD BLACK 12/PK (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789513",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: GLUEBOARDS",
                    Name = "GLUEBOARD FOR 901 FLY LIGHT (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "785058",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: GLUEBOARDS",
                    Name = "GLUEBOARD FOR 911 FLY LIGHT (25/BX)",
                    Vendor = "AP&G",
                    ProductId = "780888",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "BIG BAG FLY TRAP (12/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781595",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 170.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "FLY BAG TRAP (12/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781597",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "FRUIT FLY TRAP - BANANA SCENT (100/BX)",
                    Vendor = "AP&G",
                    ProductId = "780883",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "GOLD STICK - LARGE (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "780887",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "GOLD STICK - MINI (12/BX)",
                    Vendor = "AP&G",
                    ProductId = "780885",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 7.50,
                    OrkinPrice = 7.50,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "ONGUARD COMMERCIAL FRUIT FLY TRAP 12/BX",
                    Vendor = "UR-CAN INC.",
                    ProductId = "801831",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: FLIES: TRAPS",
                    Name = "ONGUARD COMMERCIAL FRUIT FLY TRAP HOLDER 12/PK",
                    Vendor = "UR-CAN INC.",
                    ProductId = "801832",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT",
                    Name = "LIQUID FLY & WASP BAIT 1L",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "804664",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "BUG BAR REFILLABLE BAIT STATION (50/BX)",
                    Vendor = "INNOVATIVE PEST CONTROL",
                    ProductId = "786949",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "INSECT BAIT STATION - TAN (4/BG)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "789752",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "INSECT BAIT STATION DEEP TRAY (60/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "794682",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "INSECT BAIT STATION SHALLOW TRAY (60/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "794683",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 100.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "INSECT BAIT STATION STAKE",
                    Vendor = "VM PRODUCTS",
                    ProductId = "795585",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: BAIT STATION",
                    Name = "MAXFORCE REFILLABLE BAIT STATION (48/BX)",
                    Vendor = "GNC INDUSTRIES",
                    ProductId = "787579",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: GLUEBOARDS",
                    Name = "GLUEBOARD - INSECT MONITOR (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "780882",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: GLUEBOARDS",
                    Name = "GLUEBOARD FOR EZ CONCEAL MONITORS (72/CS)",
                    Vendor = "AP&G",
                    ProductId = "801208",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "GUARD MIST FLYING INSECT SPRAY 12X180G PCP#18348",
                    Vendor = "GARDEX CHEMICALS INC.",
                    ProductId = "782444",
                    PCPNum = "18348",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "ONGUARD PD 5 DOMESTIC PRESSURIZED SPRAY (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "792212",
                    PCPNum = "30418",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 24.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "ONGUARD PNP LIQUID 1L (12/CS) PCP#32223",
                    Vendor = "UR-CAN INC.",
                    ProductId = "799439",
                    PCPNum = "32223",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "ONGUARD PROFESSIONAL P-22 RTU 1L (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "806125",
                    PCPNum = "31102",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "ONGUARD PROFESSIONAL P-22 RTU 3.78L (4/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "803762",
                    PCPNum = "31102",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: INSECTICIDE",
                    Name = "ONGUARD TOTAL INSECT 400G (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "804918",
                    PCPNum = "31225",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: MONITORS",
                    Name = "VICTOR ROACH TRAP & MONITOR (150/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "786933",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: INSECTS: TRAPS",
                    Name = "SCENTED FLY PAPER ROLL (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "789617",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES",
                    Name = "MOSQUIRON BRIQUETS (714/CS)",
                    Vendor = "PEST ALTO",
                    ProductId = "798360",
                    PCPNum = "31080",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 1745.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES: GLUEBOARDS",
                    Name = "GLUEBOARD FOR OVI-1 (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "804360",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES: GLUEBOARDS",
                    Name = "GLUEBOARD FOR OVI-CATCH PLANTER (24/CS)",
                    Vendor = "AP&G",
                    ProductId = "816039",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES: TRAPS",
                    Name = "OVI-CATCH AGO MOSQUITO TRAP (2/BX)",
                    Vendor = "AP&G",
                    ProductId = "846200",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES: TRAPS",
                    Name = "OVI-CATCH AGO MOSQUITO TRAP (2/CS)",
                    Vendor = "AP&G",
                    ProductId = "804358",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 82.00,
                    OrkinPrice = 42.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: MOSQUITOES: TRAPS",
                    Name = "OVI-PLANTER AGO MOSQUITO TRAP",
                    Vendor = "AP&G",
                    ProductId = "816034",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP",
                    Name = "CIDETRAK IMM (REGULAR DISPENSER) 36/PK PCP#32161",
                    Vendor = "TRECE, INC",
                    ProductId = "795967",
                    PCPNum = "32161",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 475.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP",
                    Name = "CIDETRAK IMM ADHESIVE HOOKS (10/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "800265",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP",
                    Name = "DIAMOND TRAP (NO LURES) (10/KT)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782065",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "DOME KIT WITH 3 RED TRAPS & 1L BAIT 2050214R",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782069",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "IMM LURES - COOPER MILL (10/PK)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782059",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "IMM PINK TRAPS - COOPER MILL (10/PK)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782058",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "MOTH SUPPRESSION ATTRACT LURES",
                    Vendor = "INSECT LIMITED, INC.",
                    ProductId = "782509",
                    PCPNum = "",
                    UOM = "JR",
                    OrkinUOM = "JR",
                    Price = 115.00,
                    OrkinPrice = 115.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "RED & CONFUSED FLOUR BEETLE LURE TRAP (10/PK)",
                    Vendor = "INSECT LIMITED, INC.",
                    ProductId = "781394",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD CIGARETTE BEETLE LURES (25/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "793883",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD CONFUSED & RFB DOME REBAIT KIT (10/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "797030",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD CONFUSED AND RED FLOUR BETTLE LURES (25/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "806139",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD CONFUSED AND RFB DOME TRAP KIT (10/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "781133",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD DOME TRAP QC ULTRA-COMBI KIT (10/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "793742",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 105.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD DOME TRAP QC ULTRA-COMBI REBAIT 6/KT (24/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "884784",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD II QC ULTRA-COMBI MONITOR 6/KT (12/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "794030",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD II TRAPS WITHOUT LURES (100/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "793744",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 375.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD INSECT MONITOR KIT IMM+4 (6 + 6)/BX (24/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "782784",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD KHAPRA AND WAREHOUSE BETTLE LURES (25/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "806138",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "STORGARD WEBBING CLOTHES MOTH LURE (25/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "793881",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "TRIBOLIUM KIT (10/KIT)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782062",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "TROGODERMA TRAP KIT 10/KT (10/CS)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782061",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "WEBBING CLOTHES MOTH TRAP 10/KT (12/CS)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782072",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "XLURE MST RTU MULTI-SPECIES TRAP CARTRIDGES (10/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789740",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "XLURE MULTI-SPECIES BEETLE MONITORING TRAP (10/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789739",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "XLURE RTU COMBO 4 PHEROMONE TRAPS 6/BG (4/CS)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781264",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "XLURE RTU INSPECTOR PHER MONITORING TRAPS (100/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781263",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: SPP: MONITORS",
                    Name = "XLURE RTU PHEROMONE MONITOR SYSTEM 6/BG (4/CS)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781265",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: TERMITES: MONITORS",
                    Name = "TERMITE MONITOR (48/CS)",
                    Vendor = "B&G EQUIPMENT",
                    ProductId = "790639",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: TICKS",
                    Name = "TICK CONTROL TUBES 48/BX (8/CS)",
                    Vendor = "THERMACELL REPELLENTS",
                    ProductId = "805464",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 165.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: AEROSOL",
                    Name = "DOKTOR DOOM JET FOAM WASP KILLER",
                    Vendor = "O/A ULTRASOL IND",
                    ProductId = "792300",
                    PCPNum = "32070",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 16.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: AEROSOL",
                    Name = "DOKTOR DOOM WASP NEST ANNIHILATOR",
                    Vendor = "O/A ULTRASOL IND",
                    ProductId = "792406",
                    PCPNum = "32170",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: EQUIPMENT",
                    Name = "STAINLESS STEEL SCRAPER FOR BEE POLES",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794400",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: INSECTICIDE",
                    Name = "ONGUARD HORNET & WASP BLASTER 400G (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800008",
                    PCPNum = "31883",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: INSECTICIDE",
                    Name = "ONGUARD HORNET & WASP FOAMING SPRAY 400G (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800010",
                    PCPNum = "31884",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "VICTOR YELLOW JACKET & FLYING INSECT TRAP (12/CS)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781626",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 105.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "WHY ATTRACTANT KIT (16/PK)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "788096",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "WHY REUSEABLE TRAP W/1 ATTRACTANT (4/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "788433",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "YELLOW JACKET TRAP DISPOSABLE - EAST FORMULA (12/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "785122",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "YELLOW JACKET TRAP DISPOSABLE - WEST FORMULA (12/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "785121",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTS: WASPS: TRAPS",
                    Name = "YELLOWJACKET TRAP DISPOSABLE DISPLAY (4/PK)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "782658",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 115.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL",
                    Name = "EARTHCARE ODOUR REMOVER BAG",
                    Vendor = "EARTH CARE PRODUCTS",
                    ProductId = "781563",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "BG",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL",
                    Name = "APPLE WAFERS (200/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790102",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL",
                    Name = "GRAPEFRUIT WAFERS (200/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790103",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL",
                    Name = "LEMON WAFER (200/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790129",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL",
                    Name = "ODOUR GRANULES RX 11.34KG",
                    Vendor = "ARMSTRONG MANUFACTURING",
                    ProductId = "791385",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL",
                    Name = "ONA POLAR CRYSTAL EXTRA STRENGTH GEL 4L (4/CS)",
                    Vendor = "ODORCHEM MANUFACTURING",
                    ProductId = "846476",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 105.00,
                    OrkinPrice = 105.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ODOUR CONTROL: ODOUR CONTROL: DISPENSERS",
                    Name = "METAL WAFER HOLDER - BLACK",
                    Vendor = "BCBC FABRICATION LTD",
                    ProductId = "806140",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 17.00,
                    OrkinPrice = 17.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OTHERS",
                    Name = "ORKIN DOCUMENT CENTER (LOGBOOK/GM)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781294",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 180.00,
                    OrkinPrice = 180.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "PPE: COVERALLS",
                    Name = "BED BUG BODY SUIT 2XL (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793087",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: COVERALLS",
                    Name = "BED BUG BODY SUIT L/XL (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793086",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: COVERALLS",
                    Name = "BED BUG BODY SUIT SM/MD (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793085",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: GLOVES",
                    Name = "NITRILE GLOVE - LARGE 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806110",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: GLOVES",
                    Name = "NITRILE GLOVE - MEDIUM 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806107",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: GLOVES",
                    Name = "NITRILE GLOVE - SMALL 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806106",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: GLOVES",
                    Name = "NITRILE GLOVE - XL 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806108",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: MASKS",
                    Name = "DISPOSABLE PROTECTIVE KN95 MASKS (5/BG)",
                    Vendor = "AKRAN MARKETING",
                    ProductId = "847310",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: MASKS",
                    Name = "FISH SHAPE MASK KN95 30/BX (50/CS)",
                    Vendor = "TRILLIUM SALES GROUP INC.",
                    ProductId = "847231",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PPE: MASKS",
                    Name = "NON-SURGICAL FACE MASK (BLUE) (50/BX)",
                    Vendor = "TRILLIUM SALES GROUP INC.",
                    ProductId = "804785",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 14.00,
                    OrkinPrice = 14.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "COLD TEMPERATURE RODENT TRAP 2PK (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "780880",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "2PK",
                    Price = 150.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUE TRAY - MOUSE (96/CS)",
                    Vendor = "AP&G",
                    ProductId = "798366",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUEBOARD - INSECT (150/BX)",
                    Vendor = "AP&G",
                    ProductId = "780890",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUEBOARD - MOUSE PEANUT SCENT (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "784018",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUEBOARD FOR SLIM MULTI-CATCH MOUSE TRAP (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "788528",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUEBOARD FOR TINCAT PEANUT SCENT (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "784426",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: GLUEBOARDS",
                    Name = "GLUEBOARD FOR TINCAT UNSCENTED (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "787099",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "EASY SET MOUSE TRAP (24/CS)",
                    Vendor = "AP&G",
                    ProductId = "791529",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "MULTI-CATCH - CLEAR LID (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "800708",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "MULTI-CATCH - SOLID LID SILVER (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801124",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "MULTI-CATCH - SOLID LID WHITE (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801123",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "MULTI-CATCH MINI - SOLID LID SILVER (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801180",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: MICE: TRAPS",
                    Name = "MULTI-CATCH MINI - SOLID LID WHITE (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "800668",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RATS: GLUEBOARDS",
                    Name = "GLUE TRAY - RAT W/O PUTTY (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "803127",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "2PK",
                    Price = 125.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RATS: GLUEBOARDS",
                    Name = "GLUE TRAY BLACK - RAT (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "798705",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "PK",
                    Price = 110.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RATS: GLUEBOARDS",
                    Name = "GLUEBOARD - RAT 12\" X 6\" (60/BX)",
                    Vendor = "AP&G",
                    ProductId = "780891",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RATS: GLUEBOARDS",
                    Name = "GLUEBOARD - RAT 18 X 10\" (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "780879",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RATS: TRAPS",
                    Name = "EASY SET RAT TRAP (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "790589",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT",
                    Name = "PRO-PEST RATS & MICE LURE 32CC SYRINGE (50/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "786893",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT",
                    Name = "PROVOKE PROFESSIONAL GEL FOR MOUSE TRAP 56G/2OZ (9/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781462",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT",
                    Name = "PROVOKE PROFESSIONAL GEL FOR RAT TRAP 224G/9OZ (9/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781463",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "BAIT STATION PLATE (24/ST)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781296",
                    PCPNum = "",
                    UOM = "ST",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ KLEAN LIQUID FEEDER",
                    Vendor = "VM PRODUCTS",
                    ProductId = "793727",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ KLEAN RODENT BAIT STATION (6/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780732",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ KLEAN RODENT BAIT STATION (6/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780736",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ SECURED RODENT BAIT STATION",
                    Vendor = "VM PRODUCTS",
                    ProductId = "782230",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ SECURED RODENT BAIT STATION - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "804475",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ SECURED RODENT BAIT STATION (60/PA) - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780735",
                    PCPNum = "",
                    UOM = "PA",
                    OrkinUOM = "EA",
                    Price = 1225.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "EZ STATION SERVICE TRAY (60/BX)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "806136",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "LIQUA-TOX BAIT DISPENSER",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "800092",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 7.50,
                    OrkinPrice = 7.50,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "MBS+ 2 BLOCK STATION (48/CS) - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "885173",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "MBS1 INSECT TRAY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802428",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 1.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "MBS1 MOUSE BAIT STATION (12/BX)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780733",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "MBS1 MOUSE BAIT STATION (12/BX) - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780737",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "MHOUSE REFILLABLE BAIT STATION (5/CS)",
                    Vendor = "LIPHATECH INC",
                    ProductId = "804572",
                    PCPNum = "30799",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA EVO AMBUSH RAT BAIT STATION - BLACK (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "791863",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA EVO CIRCUIT RAT BAIT STATION - GRAY (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "785954",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA EVO EXPRESS RAT BAIT STATION W/ WEIGHT - BLACK",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "783636",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA EVO EXPRESS RAT BAIT STATION W/ WEIGHT - GRAY",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "802150",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA EVO LANDSCAPE BAIT STATION STONE WEIGHT (2/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "799817",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA LANDSCAPE RAT BAIT STATION - GRANITE (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781456",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA LANDSCAPE RAT BAIT STATION - SANDSTONE (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781879",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA LP RAT BAIT STATION - (BLACK 6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781436",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA MICRO MOUSE BAIT STATION (12/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "785254",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA MOUSE BAIT STATION (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781467",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA RAT BAIT STATION BLACK (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781468",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA RTU MOUSE BAIT STATION (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781464",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA SCREWS (100/BG)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781466",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "PROTECTA SIDEKICK RAT BAIT STATION (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781469",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "STRONGBOX BAIT STATION BLACK (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "793418",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "TOMCAT MOUSE KILLER BAIT STATION 4/BX (12/CS) 76840 PCP#30757",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792075",
                    PCPNum = "30757",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "TOMCAT MOUSE KILLER REFILL BAIT STATION (8/CS) 76878 PCP#30657",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792076",
                    PCPNum = "306757",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: BAIT STATION",
                    Name = "TOMCAT RAT KILLER DISP BAIT STATION BAIT (4/CS) 76880 PCP#31969",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792077",
                    PCPNum = "30657",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "COPPER MESH 5\" X 100'",
                    Vendor = "D & S SPECIALTY PRODUCTS INC.",
                    ProductId = "784484",
                    PCPNum = "",
                    UOM = "RL",
                    OrkinUOM = "RL",
                    Price = 100.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "COPPER MESH 5\" X 20'",
                    Vendor = "D & S SPECIALTY PRODUCTS INC.",
                    ProductId = "784483",
                    PCPNum = "",
                    UOM = "RL",
                    OrkinUOM = "RL",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "RODENTSTOP RODENT PROOFING COMPOUND (340G/12OZ) (12/CS)",
                    Vendor = "PELGAR USA",
                    ProductId = "802039",
                    PCPNum = "",
                    UOM = "TU",
                    OrkinUOM = "TU",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "WEEP HOLE INSERT SS 2-¾\" 50/BX (8/CS)",
                    Vendor = "RID-O-MICE 2252859 ONT",
                    ProductId = "795966",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER AUTO DOOR BOTTOM SEAL ALUMINIUM 36\" 162525-36",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802267",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER DOOR SWEEP LOW PROFILE ALUMINUM 36\" 12101036-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846175",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER DOOR SWEEP LOW PROFILE ALUMINUM 48\" 12101048-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846176",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER DOOR SWEEP STANDARD ALUMINUM 36\" 11101036-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846177",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER DOOR SWEEP STANDARD ALUMINUM 48\" 11101048-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846312",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 110.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER FILL FABRIC 4\"X10' ROLLS 5/CS 162707",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "798842",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER FILL FABRIC STARTER KIT SHEARS,GLOVES & 4\"X10' ROLL162731",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "786436",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "KT",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER FRYE INSPECTION TOOL (F.I.T) (25/PK)",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802844",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER LOW PROFILE DOCK SEAL KIT 4X4' RET+16' RUBBER 162570",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846120",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 350.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER OVERHEAD DOOR RODENT SIDE SHIELD (2/PK) 162940",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806175",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER PULL CHAIN PLUG FOR DOCK LEVELERS 1.75\" 162676",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803895",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER PULL CHAIN PLUG FOR DOCK LEVELERS 2\" 162677",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803896",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER PULL CHAIN PLUG FOR DOCK LEVELERS 2.5\" 162678",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803897",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER STANDARD DOCK SEAL KIT 4X4' RET + 16' RUBBER 162550",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802157",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "CS",
                    Price = 220.00,
                    OrkinPrice = 220.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER T RUBBER BOTTOM GARAGE DOOR SEAL 4\"X75' 162654-75",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806100",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 1825.00,
                    OrkinPrice = 1855.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER VERTICAL DOOR SEAL HARDWARE MNT96\" XCL-223-00-196-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "847512",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 180.00,
                    OrkinPrice = 180.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER VERTICAL OVERHEAD SECTIONAL COM DOOR SEAL KIT 162560",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804901",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 270.00,
                    OrkinPrice = 270.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 1½\"X25'562462-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806172",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 140.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 2\"X25' 562461-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806169",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 155.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 3\"X25' 562463-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806168",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD ROLL-UP DOOR SEAL KIT 12'X4\" 162934",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805767",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD ROLL-UP DOOR SEAL KIT 8’X4” 162933",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805766",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 250.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT 8'X4\" 1½\" 162970",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804870",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "EA",
                    Price = 185.00,
                    OrkinPrice = 185.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT 8'X4\" 2\" 162972",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803519",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 215.00,
                    OrkinPrice = 215.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT12'X4\" 1½\" 162973",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804738",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT12'X4\" 1¾\" 162974",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804737",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 300.00,
                    OrkinPrice = 300.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT12'X4\" 2\" 162975",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804112",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 350.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16’X4” 2\" 162978",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805450",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 475.00,
                    OrkinPrice = 475.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16'X4\" 1½\" 162976",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804736",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 430.00,
                    OrkinPrice = 430.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16'X4\" 1¾\" 162977",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802989",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 445.00,
                    OrkinPrice = 445.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 1⅜”X1½” 562672-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805866",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 38.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 1¾\"X1¾\" 562670-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806171",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 2\"X2\" 562676-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806170",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X2 RETAINER 4'1\" T-SHAPED ALUMINUM 2\"X1⅝\" 562688-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806173",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 38.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: EXCLUSION",
                    Name = "XCLUDER X-PLATE UNIVERSAL ESCUTCHEON PLATE (24/CS) 162861-UC-24",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "886202",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "KT",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: GLUEBOARDS",
                    Name = "CATCH ZONE 60' ROLL (6/CS)",
                    Vendor = "AP&G",
                    ProductId = "802992",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 825.00,
                    OrkinPrice = 145.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: RODENTICIDE",
                    Name = "DETEX BLOX WITH LUMITRACK 4KG (2/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781949",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 90.00,
                    OrkinPrice = 90.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: RODENTICIDE",
                    Name = "HAWK ALL WEATHER BAIT CHUNX 0.8KG (6/CS)",
                    Vendor = "MOTOMCO INC",
                    ProductId = "793428",
                    PCPNum = "26595",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "EZ CONCEAL (10/BG)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802993",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "KETCH-ALL GLUEBOARDS (50/BX)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "785343",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "KETCH-ALL MOUSE TRAP",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781560",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 27.00,
                    OrkinPrice = 27.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "MINI TIN CAT GUARD",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "802252",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "MOUSE MASTER GUARD",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781298",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "MULTI-CATCH - SOLID LID WHITE WITH ORKIN STICKERS (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "800667",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "MULTI-CATCH MINI - SOLID LID SILVER (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801181",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "MULTI-CATCH MINI - SOLID LID WHITE (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801182",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "PRO-KETCH MULTI CATCH MOUSE TRAP - CLEAR LID (12/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781529",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "PROTECTA EVO TUNNEL (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "804748",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E COVER FOR MOUSE TRAP - BLACK (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794798",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E COVER FOR MOUSE TRAP - GREY (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794799",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E COVER FOR MOUSE TRAP - WHITE (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794830",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E MOUSE TRAP (72/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781544",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 4.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E RAT TRAP",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "791012",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 7.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "SNAP-E RAT TRAP COVER (9/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "803930",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 29.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TIN CAT GUARD",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781297",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TIP-TRAP LIVE CAPTURE MOUSE TRAP RETAIL 6/BX(4/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781534",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 16.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER 24/7 IQ MULTI CATCH MOUSE TRAP (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "806145",
                    PCPNum = "31969",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 235.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER 24/7 MULTI CATCH MOUSE TRAP (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781458",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER GLUE BOARD TRAY 2/PK (24/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781478",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "PK",
                    Price = 165.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER MAX GLUE TRAP (72/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781475",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER MC GLUE TRAP 48/BX (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781459",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER MINI-REX MOUSE SNAP TRAP (24/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781473",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 2.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER MONITOR & INSECT TRAP (100/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "799148",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER PEST MONITOR (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781461",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER T-REX TRAP FOR RATS (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781472",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "TRAPPER TUNNEL GLUE BOARD COVER 24/BX 2/CS",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781477",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "VICTOR GLUE TRAPS MOUSE (72/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781614",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "VICTOR WOODEN EASY SET RAT (12/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781621",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "VICTOR WOODEN EASY SET TRAP MOUSE (72/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781617",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "WIND-UP MULTIPLE CATCH MOUSE TRAP - WHITE (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "782223",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 300.00,
                    OrkinPrice = 27.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RODENTS: RODENTS: TRAPS",
                    Name = "WIND-UP MULTIPLE CATCH MOUSE TRAP - WHITE (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "782086",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHEMICAL",
                    Name = "SOAK TANK - ALUMINUM SAFE",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "787535",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHEMICAL",
                    Name = "SOAK TANK CONCENTRATE (2X5.67L)",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "782469",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 180.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHEMICAL",
                    Name = "SOAK TANK NEUTRALIZER 3.78L",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "781744",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 90.00,
                    OrkinPrice = 90.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: DISPENSERS",
                    Name = "AUTOCLEAN CHROME DISPENSER",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782200",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 42.00,
                    OrkinPrice = 42.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: PARTS",
                    Name = "AUTOCLEAN CONNECTION KIT 1 1/2\"",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782006",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: PARTS",
                    Name = "AUTOCLEAN CONNECTION KIT 3/4\"",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782004",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: PARTS",
                    Name = "AUTOCLEAN LED DISPENSER - CHROME KIT (3/4\")",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "788085",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: PARTS",
                    Name = "AUTOCLEAN STAINLESS STEEL CONNECTION TUBE (12 1/2\")",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781983",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 6.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOCLEAN: PARTS",
                    Name = "AUTOJANITOR FIXTURE TUBE (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781984",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOFLUSH: PARTS",
                    Name = "AUTOFLUSH CANADIAN FLUSH VALVE ADAPTER KIT",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781982",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 14.00,
                    OrkinPrice = 14.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOFOAM: DISPENSERS",
                    Name = "AUTOFOAM DISPENSER (1100ML) - BLACK/CHROME",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "785479",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOFOAM: DISPENSERS",
                    Name = "AUTOFOAM DISPENSER (1100ML) - WHITE/GREY",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "785679",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOFOAM: SOAP",
                    Name = "AUTOFOAM ENRICHED FOAM LOTION SOAP (4 X 1100ML)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "783255",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 37.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: AUTOFRESH: DISPENSERS",
                    Name = "AUTOFRESH LCD DISPENSER - WHITE",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782201",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 68.00,
                    OrkinPrice = 68.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: CLEANSEAT: DISPENSERS",
                    Name = "ENVIROLIGHTS FLYLIGHT JR W/ 2X25W 18\" COATED BULB",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781988",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: CLEANSEAT: REFILLS",
                    Name = "MICROBURST 9000 ECONOMIZER DISPENSER WHITE 6/CS FG401375",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "791795",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE",
                    Name = "INSTANT SOAP 'N WATER - FOAM (12/CS)",
                    Vendor = "BASF CANADA INC",
                    ProductId = "781934",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "AUTOMATIC LIQUID SOAP DISPENSER (30/CS) CD-5048AD",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "804978",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "DRIP TRAY (24/CS)",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "805764",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "GOJO FMX DISPENSER - GREY (6/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782080",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "GOJO NXT SPACE SAVER DISPENSER GRAY (6/CS) 2130-06",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781835",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "GOJO TFX SHIELD FLOOR&WALL PROTECTOR - DOVE GRAY(6/CS) 2760-06",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781829",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "HAND SANITIZER STAND W/DRIP TRAY",
                    Vendor = "BCBC FABRICATION LTD",
                    ProductId = "804902",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 205.00,
                    OrkinPrice = 205.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "PURELL NXT SPACE SAVER DISPENSER - DOVE GRAY (6/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781803",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "PURELL PAL DISPENSER HOLDER FOR 8OZ (12/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781823",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "PURELL TFX TOUCH FREE DISPENSER - GREY (12/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782788",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: DISPENSERS",
                    Name = "SENSOR SPRAY SOAP DISPENSOR 1000ML (24/CS) CD-5018AP",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "805742",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "HAND SANITIZER GEL 70% (24X236ML)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "804727",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "HAND SANITIZER GEL 70% (4X3.78L)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "804794",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 210.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "HAND SANITIZER LIQUID 80% (24X236ML)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "806103",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "HAND SANITIZER LIQUID 80% (4X3.78L)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "806102",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "PURELL ADV HAND RUB GEL FLIP CAP (24X4OZ)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781811",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "PURELL ADV HAND RUB GEL PUMP BOTTLE (12X8OZ)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781812",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "PURELL HAND SANITIZING ALC WIPES 175/CN (6/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781825",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "PURELL NXT ADVANCED INSTANT HAND (8X1000ML)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "806034",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SANITIZER",
                    Name = "PURELL TFX ADV MOIST FOAM HAND RUB (2X1200ML)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781805",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO FMX FOAMING HANDWASH PINK 4X1250ML 5161-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "846481",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 32.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO FMX-12 FOAM ANTIBC HAND AMBER 4X1250ML 5162-04-CAN00",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "805145",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 31.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO FMX-12 GREEN FOAM HAND,HAIR& BODY WASH 4X1250ML 5163-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "806035",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 29.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO NXT DELUXE LOTION SOAP W/MOIST PINK 8X1000ML 2117-08",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781834",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO PINK & KLEAN SKIN CLEANER 12X800ML 9128-12",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781836",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO TDX PRO 2000 SUPRO MAX HAND CLEANER 4X2000ML 7272-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782047",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO TFX ANTIBACTERIAL HAND FOAM 2X1200ML 5362-02-CAN00",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781828",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 100.00,
                    OrkinPrice = 52.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "GOJO TFX HANDWAS FOAM CONDITION LAVENDER 2X1200ML 5361-02",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781827",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 56.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "ONESHOT LOTION HAND SOAP REFILL 1600ML (4/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782002",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HAND HYGIENE: SOAP",
                    Name = "ONESHOT LOTION HAND SOAP REFILL 800ML (4/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782001",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE",
                    Name = "NATURELLE PLUS MAXI WITH WINGS (250/CS)",
                    Vendor = "ADVANTAGE MAINTENANCE",
                    ProductId = "781788",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "CS",
                    Price = 200.00,
                    OrkinPrice = 200.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE",
                    Name = "NATURELLE TAMPONS (200/CS)",
                    Vendor = "ADVANTAGE MAINTENANCE",
                    ProductId = "781789",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "CS",
                    Price = 100.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE: BIN",
                    Name = "FH BIN REPLACEMENT MANUAL LID - WHITE",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "802729",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE: BIN",
                    Name = "FH BIN REPLACEMENT SENSOR LID - WHITE",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "802730",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE: BIN",
                    Name = "FH BIN WALL MOUNT BRACKET",
                    Vendor = "BCBC FABRICATION LTD",
                    ProductId = "802754",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE: BIN",
                    Name = "SANITARY BIN 3 GALLON WHITE FG750243",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781987",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: HYGIENE: BIN",
                    Name = "SANITARY BIN 5 GALLON WHITE FG402338",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781985",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL",
                    Name = "ONA PRO BLOCK 170G",
                    Vendor = "ODORCHEM MANUFACTURING",
                    ProductId = "797690",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: DISPENSERS",
                    Name = "ODYSSEY AIR FRESHENER DISPENSER - WHITE (12/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801163",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 33.00,
                    OrkinPrice = 33.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: DISPENSERS",
                    Name = "RUMATE DISPENSER (10/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790117",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: DISPENSERS",
                    Name = "TCELL DISPENSER - CHROME (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781978",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: DISPENSERS",
                    Name = "TCELL DISPENSER - WHITE (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781977",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: DISPENSERS",
                    Name = "VANDAL CAGE FOR AUTOFRESH",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "782578",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: REFILLS",
                    Name = "ODOR COUNTERACTANT BATTERY FAN BUBBLE GUM 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801160",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: REFILLS",
                    Name = "ODOR COUNTERACTANT BATTERY FAN FRESHCHERRY 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801161",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: REFILLS",
                    Name = "ODOR COUNTERACTANT BATTERY FAN MULBERRY 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801158",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: REFILLS",
                    Name = "ODOR COUNTERACTANT BATTERY FAN ZESTY ORG 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "802561",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "P-SCREEN APPLE ORCHARD (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803982",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "P-SCREEN CITRUS MANGO (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800476",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "P-SCREEN CUCUMBER MELON (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803981",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "P-SCREEN KIWI GRAPEFRUIT (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800477",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "P-SCREEN LINEN BREEZE (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800479",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "WEE-SCREEN URINAL SCREEN - APPLE ORCHARD (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803980",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "WEE-SCREEN URINAL SCREEN - CITRUS MANGO (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800470",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "WEE-SCREEN URINAL SCREEN - CUCUMBER MELON (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803979",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "WEE-SCREEN URINAL SCREEN - KIWIGRAPEFRUIT (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800471",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: ODOUR CONTROL: URINAL",
                    Name = "WEE-SCREEN URINAL SCREEN - LINEN BREEZE (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800473",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: PAPER PRODUCTS: DISPENSERS",
                    Name = "TEAR-N-DRY CLASSIC PAPER TOWEL DISPENSER - BLACK PEARL",
                    Vendor = "SAN JAMAR CANADA",
                    ProductId = "782843",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 335.00,
                    OrkinPrice = 335.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: URINAL: DISPENSERS",
                    Name = "VIRTUAL JANITOR DISPENSER (6/CS)",
                    Vendor = "AMREP",
                    ProductId = "846395",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "WASHROOM CARE: WASHROOM CARE: DISPENSERS",
                    Name = "SPIRALZ DISPENSER - WHITE (24/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "800657",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "UN",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                }
            },

            ProductCategoriesFr = new ProductCategory[]
            {
                new ProductCategory()
                {
                    id = "CONTRÔLE DES ODEURS",
                    name = "CONTRÔLE DES ODEURS",
                    description = "Produits pour le contrôle des odeurs",
                    image = "oc/odour control",
                    subcategories = new string[] {"CONTRÔLE DES ODEURS"}
                },
                new ProductCategory()
                {
                    id = "ENTRETIEN DES SALLES DE TOILETTES",
                    name = "ENTRETIEN DES SALLES DE TOILETTES",
                    description = "Produits d'entretien des salles de bains",
                    image = "oc/washroom care",
                    subcategories = new string[] {"AUTOCLEAN", "AUTOCLEAN: DISPENSERS", "AUTOCLEAN: PIÈCES", "AUTOFLUSH", "AUTOFLUSH: PIÈCES", "AUTOFOAM", "AUTOFOAM: DISPENSERS", "AUTOFOAM: SAVON", "AUTOFRESH", "AUTOFRESH: DISPENSERS", "CLEANSEAT", "CLEANSEAT: DISPENSERS", "CLEANSEAT: RECHARGES", "CONTRÔLE DES ODEURS", "CONTRÔLE DES ODEURS: DISPENSERS", "CONTRÔLE DES ODEURS: RECHARGES", "CONTRÔLE DES ODEURS: URINOIR", "HYGIÈNE", "HYGIÈNE DES MAINS", "HYGIÈNE DES MAINS: DÉSINFECTANT", "HYGIÈNE DES MAINS: DISPENSERS", "HYGIÈNE DES MAINS: SAVON", "HYGIÈNE: DÉSINFECTANT", "HYGIÈNE: DISPENSERS", "HYGIÈNE: POUBELLE", "HYGIÈNE: SAVON", "URINOIR", "URINOIR: DISPENSERS", "WASHROOM CARE", "WASHROOM CARE: DISPENSERS"}
                },
                new ProductCategory()
                {
                    id = "ENTRETIEN DES VIDANGES",
                    name = "ENTRETIEN DES VIDANGES",
                    description = "Produits d'entretien pour les drains",
                    image = "oc/drain maintenance",
                    subcategories = new string[] {"MOUSSE"}
                },
                new ProductCategory()
                {
                    id = "EPI",
                    name = "EPI",
                    description = "Équipement de protection personnelle",
                    image = "oc/ppe",
                    subcategories = new string[] {"COMBINAISON", "GANTS", "MASQUES"}
                },
                new ProductCategory()
                {
                    id = "ÉQUIPEMENT",
                    name = "ÉQUIPEMENT",
                    description = "Équipement de lutte contre les parasites",
                    image = "oc/equipment",
                    subcategories = new string[] { }
                },
                new ProductCategory()
                {
                    id = "INSECTES",
                    name = "INSECTES",
                    description = "produits pour les insectes",
                    image = "oc/pest/insect",
                    subcategories = new string[] {"FOURMIS", "FOURMIS: STATION D'APPÂT", "GUÊPES", "GUÊPES: AÉROSOL", "GUÊPES: ÉQUIPEMENT", "GUÊPES: INSECTICIDE", "GUÊPES: PIÈGES", "INSECTES", "INSECTES: APPÂT", "INSECTES: GLUAUX", "INSECTES: INSECTICIDE", "INSECTES: MONITEURS", "INSECTES: PIÈGES", "INSECTES: STATION D'APPÂT", "MOUCHES", "MOUCHES: GLUAUX", "MOUCHES: PIÈGES", "MOUCHES: PIÈGES LUMINEUX", "MOUCHES: STATION D'APPÂT", "MOUSTIQUES", "MOUSTIQUES: GLUAUX", "MOUSTIQUES: PIÈGES", "PUNAISES DE LIT", "PUNAISES DE LIT: AÉROSOL", "PUNAISES DE LIT: APPÂT", "PUNAISES DE LIT: COUVRES", "PUNAISES DE LIT: INSECTICIDE", "PUNAISES DE LIT: MONITEURS", "SPP", "SPP: MONITEURS", "TERMITES", "TERMITES: MONITEURS", "TIQUES"}
                },
                new ProductCategory()
                {
                    id = "OISEAUX / FAUNE",
                    name = "OISEAUX / FAUNE",
                    description = "produits pour les oiseaux et la faune sauvage",
                    image = "oc/pest/bird & wildlife",
                    subcategories = new string[] {"CHAUVES-SOURIS", "CHAUVES-SOURIS: PIÈGES", "FAUNE", "FAUNE: ÉQUIPEMENT", "FAUNE: EXCLUSION", "FAUNE: PIÈGES", "MOUFFETTES", "MOUFFETTES: PIÈGES", "OISEAUX", "OISEAUX: DETERRENTS", "OISEAUX: PIÈGES", "OISEAUX: POINTES"}
                },
                new ProductCategory()
                {
                    id = "OTHERS",
                    name = "OTHERS",
                    description = "Other products",
                    image = "oc/orkinonsite",
                    subcategories = new string[] { }
                },
                new ProductCategory()
                {
                    id = "PRODUITS DE NETTOYAGE",
                    name = "PRODUITS DE NETTOYAGE",
                    description = "Produits de nettoyage et de désinfection",
                    image = "oc/cleaner",
                    subcategories = new string[] {"ACTIZYME", "DÉSINFECTANT", "MOUSSE"}
                },
                new ProductCategory()
                {
                    id = "RONGEURS",
                    name = "RONGEURS",
                    description = "produits pour les rongeurs",
                    image = "oc/pest/rodent",
                    subcategories = new string[] {"RATS", "RATS: GLUAUX", "RATS: PIÈGES", "RONGEURS", "RONGEURS: APPÂT", "RONGEURS: DETERRENTS", "RONGEURS: EXCLUSION", "RONGEURS: GLUAUX", "RONGEURS: PIÈGES", "RONGEURS: RODENTICIDE", "RONGEURS: STATION D'APPÂT", "SOURIS", "SOURIS: GLUAUX", "SOURIS: PIÈGES"}
                },
                new ProductCategory()
                {
                    id = "SOAK TANK",
                    name = "SOAK TANK",
                    description = "Produits pour les SoakTanks",
                    image = "oc/soak tank",
                    subcategories = new string[] {"CHIMIQUE"}
                }
            },

            ProductsFr = new Product[]
            {
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS",
                    Name = "SAC POU ÉLIMINATION DES ODEURS 1,5 LB",
                    Vendor = "EARTH CARE PRODUCTS",
                    ProductId = "781563",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "BG",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS: CONTRÔLE DES ODEURS",
                    Name = "ECO WAFER - LIMETTE",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790129",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS: CONTRÔLE DES ODEURS",
                    Name = "ECO WAFER - PAMPLEMOUSSE",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790103",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS: CONTRÔLE DES ODEURS",
                    Name = "ECO WAFER - POMME",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790102",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 700.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS: CONTRÔLE DES ODEURS",
                    Name = "ENG - ONA POLAR CRYSTAL EXTRA STRENGTH GEL 4L (4/CS)",
                    Vendor = "ODORCHEM MANUFACTURING",
                    ProductId = "846476",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 105.00,
                    OrkinPrice = 105.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "CONTRÔLE DES ODEURS: CONTRÔLE DES ODEURS",
                    Name = "ODOUR GRANULAR RX (SEAU DE 25 LB)",
                    Vendor = "ARMSTRONG MANUFACTURING",
                    ProductId = "791385",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: DISPENSERS",
                    Name = "ENG - AUTOCLEAN CHROME DISPENSER",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782200",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 42.00,
                    OrkinPrice = 42.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: PIÈCES",
                    Name = "ENG - AUTOCLEAN CONNECTION KIT 1 1/2\"",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782006",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: PIÈCES",
                    Name = "ENG - AUTOCLEAN CONNECTION KIT 3/4\"",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782004",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: PIÈCES",
                    Name = "ENG - AUTOCLEAN LED DISPENSER - CHROME KIT (3/4\")",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "788085",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: PIÈCES",
                    Name = "ENG - AUTOCLEAN STAINLESS STEEL CONNECTION TUBE (12 1/2\")",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781983",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 6.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOCLEAN: PIÈCES",
                    Name = "ENG - AUTOJANITOR FIXTURE TUBE (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781984",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOFLUSH: PIÈCES",
                    Name = "ENG - AUTOFLUSH CANADIAN FLUSH VALVE ADAPTER KIT",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781982",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 14.00,
                    OrkinPrice = 14.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOFOAM: DISPENSERS",
                    Name = "ENG - AUTOFOAM DISPENSER (1100ML) - BLACK/CHROME",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "785479",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOFOAM: DISPENSERS",
                    Name = "ENG - AUTOFOAM DISPENSER (1100ML) - WHITE/GREY",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "785679",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOFOAM: SAVON",
                    Name = "ENG - AUTOFOAM ENRICHED FOAM LOTION SOAP (4 X 1100ML)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "783255",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 37.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: AUTOFRESH: DISPENSERS",
                    Name = "ENG - AUTOFRESH LCD DISPENSER - WHITE",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782201",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 68.00,
                    OrkinPrice = 68.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CLEANSEAT: DISPENSERS",
                    Name = "ENG - ENVIROLIGHTS FLYLIGHT JR W/ 2X25W 18\" COATED BULB",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781988",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CLEANSEAT: RECHARGES",
                    Name = "ENG - MICROBURST 9000 ECONOMIZER DISPENSER WHITE 6/CS FG401375",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "791795",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS",
                    Name = "ONA PRO BLOCK 170G",
                    Vendor = "ODORCHEM MANUFACTURING",
                    ProductId = "797690",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: DISPENSERS",
                    Name = "ENG - ODYSSEY AIR FRESHENER DISPENSER - WHITE (12/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801163",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 33.00,
                    OrkinPrice = 33.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: DISPENSERS",
                    Name = "ENG - RUMATE DISPENSER (10/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "790117",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: DISPENSERS",
                    Name = "ENG - TCELL DISPENSER - CHROME (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781978",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: DISPENSERS",
                    Name = "ENG - TCELL DISPENSER - WHITE (12/CS)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781977",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: DISPENSERS",
                    Name = "SE RENSEIGNER CAGE À L’ÉPREUVE DE VANDALISME POUR  AUTO FRESH",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "782578",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: RECHARGES",
                    Name = "ENG - ODOR COUNTERACTANT BATTERY FAN BUBBLE GUM 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801160",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: RECHARGES",
                    Name = "ENG - ODOR COUNTERACTANT BATTERY FAN FRESHCHERRY 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801161",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: RECHARGES",
                    Name = "ENG - ODOR COUNTERACTANT BATTERY FAN MULBERRY 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "801158",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: RECHARGES",
                    Name = "ENG - ODOR COUNTERACTANT BATTERY FAN ZESTY ORG 133ML (48/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "802561",
                    PCPNum = "",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "ENG - P-SCREEN APPLE ORCHARD (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803982",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "ENG - P-SCREEN CUCUMBER MELON (6/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803981",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "ENG - WEE-SCREEN URINAL SCREEN - APPLE ORCHARD (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803980",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "ENG - WEE-SCREEN URINAL SCREEN - CUCUMBER MELON (10/CS)",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "803979",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR P-SCREEN - CITRUS MANGO",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800476",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR P-SCREEN - LINEN BREEZE",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800479",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR P-SCREEN- KIWI PAMPLEMOUSSE",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800477",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR WEE-SCREEN - CITRUS MANGO",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800470",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR WEE-SCREEN - KIWI PAMPLEMOUSSE",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800471",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: CONTRÔLE DES ODEURS: URINOIR",
                    Name = "TAMIS D’URINOIR WEE-SCREEN - LINEN BREEZE",
                    Vendor = "VECTAIR SYSTEMS INC",
                    ProductId = "800473",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE",
                    Name = "ENG - NATURELLE PLUS MAXI WITH WINGS (250/CS)",
                    Vendor = "ADVANTAGE MAINTENANCE",
                    ProductId = "781788",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "CS",
                    Price = 200.00,
                    OrkinPrice = 200.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE",
                    Name = "ENG - NATURELLE TAMPONS (200/CS)",
                    Vendor = "ADVANTAGE MAINTENANCE",
                    ProductId = "781789",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "CS",
                    Price = 100.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS",
                    Name = "ENG - INSTANT SOAP 'N WATER - FOAM (12/CS)",
                    Vendor = "BASF CANADA INC",
                    ProductId = "781934",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "DÉSINFECTANT POUR LES MAINS EN GEL 3,79 L",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "804794",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 210.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "DÉSINFECTANT POUR LES MAINS PURELL - BOUTEILLE 8OZ",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781812",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "DÉSINFECTANT POUR LES MAINS PURELL - CAPSULE AMOVIBLE 4OZ",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781811",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "ENG - HAND SANITIZER LIQUID 80% (24X236ML)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "806103",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "ENG - HAND SANITIZER LIQUID 80% (4X3.78L)",
                    Vendor = "HERETIC SPIRITS",
                    ProductId = "806102",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "ENG - PURELL NXT ADVANCED INSTANT HAND (8X1000ML)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "806034",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "LINGETTES DÉSINFECTANTES POUR LES MAINS PURELL",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781825",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DÉSINFECTANT",
                    Name = "MOUSSE ANTIBACTÉRIENNE PURELL 70 % 1200ML (POUR DISTRIBUTEUR TFX)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781805",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "DISTRIBUTEUR NXT SPACE SAVER (GRIS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781803",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "DISTRIBUTEUR NXT SPACE SAVER (GRIS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781835",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "DISTRIBUTEUR TFX MAINS LIBRES (GRIS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782788",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "ENG - DRIP TRAY (24/CS)",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "805764",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "ENG - GOJO FMX DISPENSER - GREY (6/CS)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782080",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "ENG - GOJO TFX SHIELD FLOOR&WALL PROTECTOR - DOVE GRAY(6/CS) 2760-06",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781829",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: DISPENSERS",
                    Name = "PAL - SUPPORT POUR PURELL 8OZ - DÉSINFECTANT POUR LES MAINS",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781823",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "ENG - GOJO FMX FOAMING HANDWASH PINK 4X1250ML 5161-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "846481",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 32.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "ENG - GOJO FMX-12 FOAM ANTIBC HAND AMBER 4X1250ML 5162-04-CAN00",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "805145",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 31.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "ENG - GOJO FMX-12 GREEN FOAM HAND,HAIR& BODY WASH 4X1250ML 5163-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "806035",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 29.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "ENG - GOJO TDX PRO 2000 SUPRO MAX HAND CLEANER 4X2000ML 7272-04",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "782047",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "ENG - GOJO TFX HANDWAS FOAM CONDITION LAVENDER 2X1200ML 5361-02",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781827",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 56.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "LOTION SAVONNEUSE ONE SHOT 1600ML (POUR DISTRIBUTEUR AUTO SOAP)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782002",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "LOTION SAVONNEUSE ONE SHOT 800ML (POUR DISTRIBUTEUR AUTO SOAP)",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "782001",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "SAVON EN MOUSSE ANTÉBACTÉRIEN 1200ML (POUR DISTRIBUTEUR TFX)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781828",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 100.00,
                    OrkinPrice = 52.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "SAVON ROSE AVEC HYDRATANT 1000ML (POUR DISTRIBUTEUR NXT)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781834",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE DES MAINS: SAVON",
                    Name = "SAVON ROSE ET PROPRE 800ML (POUR DISTRIBUTEUR TFX)",
                    Vendor = "GOJO INDUSTRIES",
                    ProductId = "781836",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE: POUBELLE",
                    Name = "ENG - FH BIN REPLACEMENT MANUAL LID - WHITE",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "802729",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE: POUBELLE",
                    Name = "ENG - FH BIN REPLACEMENT SENSOR LID - WHITE",
                    Vendor = "CHANGDIAN CHINA LIMITED",
                    ProductId = "802730",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE: POUBELLE",
                    Name = "ENG - FH BIN WALL MOUNT BRACKET",
                    Vendor = "BCBC FABRICATION LTD",
                    ProductId = "802754",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: HYGIÈNE: POUBELLE",
                    Name = "ENG - SANITARY BIN 5 GALLON WHITE FG402338",
                    Vendor = "RUBBERMAID COMMERCIAL",
                    ProductId = "781985",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: URINOIR: DISPENSERS",
                    Name = "ENG - VIRTUAL JANITOR DISPENSER (6/CS)",
                    Vendor = "AMREP",
                    ProductId = "846395",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES SALLES DE TOILETTES: WASHROOM CARE: DISPENSERS",
                    Name = "ENG - SPIRALZ DISPENSER - WHITE (24/CS)",
                    Vendor = "ALPHA AROMATICS",
                    ProductId = "800657",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "UN",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES VIDANGES",
                    Name = "ENG - GREASEAWAY 3.78L",
                    Vendor = "GENESIS BIOSCIENCES",
                    ProductId = "781411",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 28.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ENTRETIEN DES VIDANGES: MOUSSE",
                    Name = "ENG - BIOPLUS FOAM & LIQUID FORMULATION (6/CS)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "782077",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: COMBINAISON",
                    Name = "ENG - BED BUG BODY SUIT 2XL (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793087",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: COMBINAISON",
                    Name = "ENG - BED BUG BODY SUIT L/XL (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793086",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: COMBINAISON",
                    Name = "ENG - BED BUG BODY SUIT SM/MD (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793085",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: GANTS",
                    Name = "ENG - NITRILE GLOVE - LARGE 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806110",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: GANTS",
                    Name = "ENG - NITRILE GLOVE - MEDIUM 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806107",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: GANTS",
                    Name = "ENG - NITRILE GLOVE - SMALL 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806106",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: GANTS",
                    Name = "ENG - NITRILE GLOVE - XL 4MIL - BLACK",
                    Vendor = "SHOWA",
                    ProductId = "806108",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: MASQUES",
                    Name = "ENG - DISPOSABLE PROTECTIVE KN95 MASKS (5/BG)",
                    Vendor = "AKRAN MARKETING",
                    ProductId = "847310",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "EPI: MASQUES",
                    Name = "ENG - NON-SURGICAL FACE MASK (BLUE) (50/BX)",
                    Vendor = "TRILLIUM SALES GROUP INC.",
                    ProductId = "804785",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 14.00,
                    OrkinPrice = 14.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - BOSS PRO 320 10L (2.5G) 18V BACKPACK SPRAYER",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "799575",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "BX",
                    Price = 750.00,
                    OrkinPrice = 750.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - BOSS PRO 512 18V BACKPACK SPRAYER (4L)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "796542",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - FOAMER SIMPSON 5G",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "804651",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 390.00,
                    OrkinPrice = 390.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - SPARTA FLOOR DRAIN BRUSH 3\" DIAMATER",
                    Vendor = "RABCO FOODSERVICES LIMITE",
                    ProductId = "780830",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - SPARTA FLOOR DRAIN HANDLE PLASTIC 36\"",
                    Vendor = "RABCO FOODSERVICES LIMITE",
                    ProductId = "780829",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "ENG - WEBSTER COB WEB DUSTER HEAD - BLUE (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794901",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "MANCHE PRO LINE (118 PO.) POUR PLUMEAU INDUSTRIEL",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "781746",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "PLUMEAU INDUSTRIEL POUR TOILE D’ARAIGNÉE (JAUNE)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "781745",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "ÉQUIPEMENT",
                    Name = "PULVÉRISATEUR ÉLECTROSTATIQUE",
                    Vendor = "UNIMANIX INDUSTRIES INC",
                    ProductId = "805398",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 950.00,
                    OrkinPrice = 950.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES",
                    Name = "ONGUARD PRO-PERM INSECT KILLER 3.78L (4/CS) PCP#32333",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800244",
                    PCPNum = "32333",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: FOURMIS: STATION D'APPÂT",
                    Name = "ENG - ANT CAFE BAIT STATION (48/BAG)",
                    Vendor = "INNOVATIVE PEST CONTROL",
                    ProductId = "801850",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: FOURMIS: STATION D'APPÂT",
                    Name = "ENG - ANTS NO MORE BAIT STATIONS (12/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781535",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 46.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: FOURMIS: STATION D'APPÂT",
                    Name = "ENG - TERRO LIQUID ANT BAIT STATION 6/PK (12/CS) T300CAN PCP#30897",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "797942",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: AÉROSOL",
                    Name = "ENG - DOKTOR DOOM JET FOAM WASP KILLER",
                    Vendor = "O/A ULTRASOL IND",
                    ProductId = "792300",
                    PCPNum = "32070",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 16.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: AÉROSOL",
                    Name = "ENG - DOKTOR DOOM WASP NEST ANNIHILATOR",
                    Vendor = "O/A ULTRASOL IND",
                    ProductId = "792406",
                    PCPNum = "32170",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: ÉQUIPEMENT",
                    Name = "ENG - STAINLESS STEEL SCRAPER FOR BEE POLES",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794400",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: INSECTICIDE",
                    Name = "ONGUARD DESTRUCTEUR DE GUÊPES ET FRELONS",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800008",
                    PCPNum = "31883",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: INSECTICIDE",
                    Name = "ONGUARD MOUSSEUX CONTRE GUÊPES ET FRELONS",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800010",
                    PCPNum = "31884",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "ENG - WHY ATTRACTANT KIT (16/PK)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "788096",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "ENG - WHY REUSEABLE TRAP W/1 ATTRACTANT (4/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "788433",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "ENG - YELLOWJACKET TRAP DISPOSABLE DISPLAY (4/PK)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "782658",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 115.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "PIÈGE JETABLE POUR GUÊPES JAUNES  EST",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "785122",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "PIÈGE JETABLE POUR GUÊPES JAUNES  OUEST",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "785121",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: GUÊPES: PIÈGES",
                    Name = "PIÈGE POUR INSECTE VOLANT AVEC APPÂT",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781626",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 105.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: APPÂT",
                    Name = "ENG - LIQUID FLY & WASP BAIT 1L",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "804664",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: GLUAUX",
                    Name = "GLUAU DE REMPLACEMENT EZ CONCEAL",
                    Vendor = "AP&G",
                    ProductId = "801208",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: GLUAUX",
                    Name = "MONITEUR À INSECTES ODEUR D’ARACHIDES (NON ALLERGIQUE)",
                    Vendor = "AP&G",
                    ProductId = "780882",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "AÉROSOL ONGUARD PD5",
                    Vendor = "UR-CAN INC.",
                    ProductId = "792212",
                    PCPNum = "30418",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 24.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "ENG - GUARD MIST FLYING INSECT SPRAY 12X180G PCP#18348",
                    Vendor = "GARDEX CHEMICALS INC.",
                    ProductId = "782444",
                    PCPNum = "18348",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "ENG - ONGUARD PROFESSIONAL P-22 RTU 1L (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "806125",
                    PCPNum = "31102",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "ENG - ONGUARD PROFESSIONAL P-22 RTU 3.78L (4/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "803762",
                    PCPNum = "31102",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "ENG - ONGUARD TOTAL INSECT 400G (12/CS)",
                    Vendor = "UR-CAN INC.",
                    ProductId = "804918",
                    PCPNum = "31225",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: INSECTICIDE",
                    Name = "ONGUARD PNP 1L INSECTICIDE LIQUIDE",
                    Vendor = "UR-CAN INC.",
                    ProductId = "799439",
                    PCPNum = "32223",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: MONITEURS",
                    Name = "ENG - VICTOR ROACH TRAP & MONITOR (150/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "786933",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: PIÈGES",
                    Name = "ENG - SCENTED FLY PAPER ROLL (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "789617",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - BUG BAR REFILLABLE BAIT STATION (50/BX)",
                    Vendor = "INNOVATIVE PEST CONTROL",
                    ProductId = "786949",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - INSECT BAIT STATION - TAN (4/BG)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "789752",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - INSECT BAIT STATION DEEP TRAY (60/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "794682",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - INSECT BAIT STATION SHALLOW TRAY (60/CS)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "794683",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 100.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - INSECT BAIT STATION STAKE",
                    Vendor = "VM PRODUCTS",
                    ProductId = "795585",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: INSECTES: STATION D'APPÂT",
                    Name = "ENG - MAXFORCE REFILLABLE BAIT STATION (48/BX)",
                    Vendor = "GNC INDUSTRIES",
                    ProductId = "787579",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: GLUAUX",
                    Name = "ENG - GLUEBOARD FOR 901 FLY LIGHT (24/BX)",
                    Vendor = "AP&G",
                    ProductId = "785058",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: GLUAUX",
                    Name = "GLUAU POUR PIÈGE LUMINEUX 911",
                    Vendor = "AP&G",
                    ProductId = "780888",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "ENG - FRUIT FLY TRAP - BANANA SCENT (100/BX)",
                    Vendor = "AP&G",
                    ProductId = "780883",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "PIÈGE À DROSOPHILE DROP IN",
                    Vendor = "UR-CAN INC.",
                    ProductId = "801831",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "PIÈGE GOLD STICK (12 PO.) PETIT",
                    Vendor = "AP&G",
                    ProductId = "780885",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 7.50,
                    OrkinPrice = 7.50,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "PIÈGE GOLD STICK (24 PO.) GRAND",
                    Vendor = "AP&G",
                    ProductId = "780887",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "SAC POUR MOUCHES",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781597",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "SAC POUR MOUCHES - GRAND",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781595",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 170.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES",
                    Name = "SUPPORT POUR PIÈGES À DROSOPHILES DROP IN",
                    Vendor = "UR-CAN INC.",
                    ProductId = "801832",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "18W T8 24\" SHATTER RESISTANT BULBS (2/PK) - FOR CHAMELEON FLY LIGHT)",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "883534",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "COBRA LED LIGHT - REPLACEMENT COVER",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "883472",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 16\" 36W SLEEVED BL BULB 10/CS 213602-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "786105",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 375.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 18 LED LONG STRIP 2/PK (8/CS) 500-31808-L18",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806002",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 18W T8 24\" SLEEVED BL BULB 25/CS 213802-51",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794175",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 18W T8 24\" STANDARD BL BULB 25/CS 213800-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794137",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 190.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 20W T12 24\" STANDARD BULB FOR GILBERT 601 (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789419",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 215.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 30 LED LONG STRIP2/PK(8/CS) LED300-102 500-330008-L30",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806003",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 68.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 32W T12 18\" STANDARD BL BULB 25/CS 213712-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794443",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 270.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - 40W T12 48\" STANDARD BULB FOR GARDNER (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789423",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 440.00,
                    OrkinPrice = 19.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - BUG ZAPPER LIGHT TRAP 2X40W 48\" BULB - WHITE",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781055",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 595.00,
                    OrkinPrice = 595.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - CATCH TRAY FOR 601T / 601TJ FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "796509",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - CFL 36W 16\" ELECTROSECT SLEEVED BL BULB (10/CS) 213602-00",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "792645",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - ENVIROLIGHTS FLYLIGHT JR W/ 2X25W 18\" COATED BULB",
                    Vendor = "DIRECT LINE SALES & SUPPLY",
                    ProductId = "791311",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - FLY WEB 9W BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781096",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 17.00,
                    OrkinPrice = 17.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - FLYING VENUS 2000GT FLY LIGHT - BLACK",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781333",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 285.00,
                    OrkinPrice = 285.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - FLYING VENUS 2000GT FLY LIGHT - WHITE",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781332",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 280.00,
                    OrkinPrice = 280.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - FLYING VENUS 2002GT FLY LIGHT - BLACK",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781330",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - FLYLITE ELECTRIC GRID TRAP W/2X40W 48\" SHATTERPROOF AG-661S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "846424",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 885.00,
                    OrkinPrice = 885.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER BULB 15W 18\" SHATTERPROOF 25/CS CS-06S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781066",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER BULB 25W 18\" SHATTERPROOF 2/PK EL-082S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781885",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER BULB 36W T4 16\" (10/CS) EL-12",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "787665",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 17.00,
                    OrkinPrice = 17.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER BULB 40W 48\" 2/PK EL-092",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781095",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER WALL SCONCE FLY LIGHT - GOLD",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "780993",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 235.00,
                    OrkinPrice = 235.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER WALL SCONCE FLY LIGHT - WHITE 1X18\" BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781048",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GARDNER WALL SCONCE FLY LIGHT - WHITE 2X18\" BULB",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "799666",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS ECLIPSE ULTRA FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794177",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS FLI FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785300",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - BRASS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806159",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 315.00,
                    OrkinPrice = 315.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS ILLUME ALPHA FLUORESCENT FLY LIGHT - STAINLESS (SLEEVED BULBS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806157",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 290.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS SPECTRA COMPACT FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789727",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GENUS SPECTRA FLUORESCENT FLY LIGHT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789726",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 550.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GILBERT BALLAST FOR 20W UNITS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "800093",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GILBERT BALLAST FOR 40W UNITS (UNITS MADE AFTER NOV 2005)",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "782212",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GUARD FOR 601TGT / 601GT FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "805808",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GUERRILLA 220 W/2X20W BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781320",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 595.00,
                    OrkinPrice = 595.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - GUERRILLA 220-SC W/2X20W SHATTERCATCH BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "788187",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 600.00,
                    OrkinPrice = 600.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - MANTIS FLY LIGHT",
                    Vendor = "PESTWEST USA LLC",
                    ProductId = "783030",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 280.00,
                    OrkinPrice = 280.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - MANTIS FLY LIGHT GLUEBOARD (6/PK)",
                    Vendor = "PESTWEST USA LLC",
                    ProductId = "781398",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - NIGHT HAWK FLY LIGHT",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781322",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - STARTER FOR GT-180 / WS-85 FLY LIGHTS",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781098",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - STARTER FOR GT-200 / MX-360 / AG-XXX FLY LIGHTS",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781097",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - STICKY LIZARD 601GT-SC W/2X20W SHATTERCATCH BULB",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "847001",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 420.00,
                    OrkinPrice = 420.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - T5 12\" STANDARD BLUE BULB FOR ECLIPSE/ALPHA LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "786104",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 425.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - T5 12\" STANDARD REGULAR BULB FOR ECLIPSE/ALPHA LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "799731",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - T8 18\" STANDARD BULB FOR FLI/ORBIT/LIBERATOR/VIPER LIGHTS (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789414",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - TRANSFORMER FOR GILBERT FLY LIGHTS",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "782211",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - UNIVERSAL GLUE BOARD - WHITE 12/PK",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794144",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ENG - UNIVERSAL GLUE BOARD BLACK 12/PK (25/CS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789513",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "GENUS SPECTRA COMPACT 230H LED FLY LIGHT (COMES WITH SLEEVED LED STRIPS)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "882736",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 385.00,
                    OrkinPrice = 385.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "GLUAU POUR PIÈGE ILLUME ALPHA",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797419",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 28.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "GLUAUX POUR PIÈGE FLYWEB PLUG-IN",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "782236",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 16.00,
                    OrkinPrice = 16.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME ALPHA BLANC",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797413",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME ALPHA LAITON",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797411",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 295.00,
                    OrkinPrice = 295.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME ALPHA NOIR",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797410",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 185.00,
                    OrkinPrice = 185.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME GALAXY ACIER INOXYDABLE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797415",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME GALAXY BLANC",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797416",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME GALAXY LAITON",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797417",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 275.00,
                    OrkinPrice = 275.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "ILLUME GALAXY NOIR",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "797414",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 225.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON 36 W 16 PO. 213600 - BRANDENBURG (CHACUN)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794380",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON ANTI-ÉCLAT 15 W 18 PO. (BOÎTE DE 2)",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "782470",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON ANTI-ÉCLAT 20 W 24 PO.",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781067",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON ANTI-ÉCLAT 25 W 18 PO. T8  213704",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789420",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 500.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON ANTI-ÉCLAT 32 W 18 PO. EL-05S",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781090",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 600.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON ANTI-ÉCLAT 40 W 48 PO.",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781093",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 790.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON RÉGULIER 15 W 18 PO.",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "781061",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON T12  20 W X 24 PO. AVEC GAINE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789415",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 800.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON T12 40 W X 48 PO. AVEC GAINE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789425",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 1125.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "NÉON T8 15 W X 18 PO. AVEC GAINE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "789458",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX DON 601T",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781317",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 550.00,
                    OrkinPrice = 550.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX FLYWEB ENFICHABLE",
                    Vendor = "GARDNER MANUFACTURING CO",
                    ProductId = "780987",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS COBRA DEL",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806163",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 395.00,
                    OrkinPrice = 395.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ECLIPSE BLANC",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785894",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 220.00,
                    OrkinPrice = 220.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS FLI DEL",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806164",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 365.00,
                    OrkinPrice = 365.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ILLUMÉ GALAXY DEL (ACIER INOXYDABLE)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806005",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ILLUMÉ GALAXY DEL (BLANC)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806007",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 290.00,
                    OrkinPrice = 290.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ILLUMÉ GALAXY DEL (NOIR)",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "806006",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 310.00,
                    OrkinPrice = 310.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ORBIT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785246",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 485.00,
                    OrkinPrice = 485.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS ORBIT JET PROOF",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785299",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 625.00,
                    OrkinPrice = 625.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX GENUS SPECTRA",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785301",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 360.00,
                    OrkinPrice = 360.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX JUNIOR 601T",
                    Vendor = "GILBERT INDUSTRIES INC.",
                    ProductId = "781319",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 535.00,
                    OrkinPrice = 535.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX LIBERATOR SP SS 4X15W",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796007",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 940.00,
                    OrkinPrice = 940.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX LIBERATORA ACIER INOXYDABLE",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "794444",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 850.00,
                    OrkinPrice = 850.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX PORTABLE GLOSTIK (À PILES)",
                    Vendor = "AP&G",
                    ProductId = "784689",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX VIPER 30",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796688",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 395.00,
                    OrkinPrice = 395.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGE LUMINEUX VIPER 60",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "796687",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 650.00,
                    OrkinPrice = 650.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "PIÈGES LUMINEUX GENUS SPECTRA COMPACT",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785302",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 260.00,
                    OrkinPrice = 260.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: PIÈGES LUMINEUX",
                    Name = "UNIVERSAL GLUE BOARD - BLACK 12/PK",
                    Vendor = "BRANDENBURG NA",
                    ProductId = "785395",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: STATION D'APPÂT",
                    Name = "ENG - FLY BAIT STATION - GREY (4/BG)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802294",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: STATION D'APPÂT",
                    Name = "ENG - FLY BAIT STATION REPLACEMENT TRAY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802378",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 2.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUCHES: STATION D'APPÂT",
                    Name = "ENG - FLY BAIT STATION STAKE",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802295",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 5.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES",
                    Name = "ENG - MOSQUIRON BRIQUETS (714/CS)",
                    Vendor = "PEST ALTO",
                    ProductId = "798360",
                    PCPNum = "31080",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 1745.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES: GLUAUX",
                    Name = "ENG - GLUEBOARD FOR OVI-1 (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "804360",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES: GLUAUX",
                    Name = "ENG - GLUEBOARD FOR OVI-CATCH PLANTER (24/CS)",
                    Vendor = "AP&G",
                    ProductId = "816039",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES: PIÈGES",
                    Name = "ENG - OVI-CATCH AGO MOSQUITO TRAP (2/BX)",
                    Vendor = "AP&G",
                    ProductId = "846200",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES: PIÈGES",
                    Name = "ENG - OVI-CATCH AGO MOSQUITO TRAP (2/CS)",
                    Vendor = "AP&G",
                    ProductId = "804358",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 82.00,
                    OrkinPrice = 42.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: MOUSTIQUES: PIÈGES",
                    Name = "ENG - OVI-PLANTER AGO MOSQUITO TRAP",
                    Vendor = "AP&G",
                    ProductId = "816034",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT",
                    Name = "SAC À LESSIVE HYDROSOLUBLE  (25 PAR PAQUET)",
                    Vendor = "HOLLANDER SLEEP & DECOR",
                    ProductId = "782446",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT",
                    Name = "SAC À LESSIVE HYDROSOLUBLE - LAVEUSE À CHARGEMENT FRONTAL (25 PAR PACKET)",
                    Vendor = "HOLLANDER SLEEP & DECOR",
                    ProductId = "789439",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: AÉROSOL",
                    Name = "ENG - DX13 BED BUG KILLER 400G",
                    Vendor = "DE LABORATORIES INC.",
                    ProductId = "798815",
                    PCPNum = "30973",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: APPÂT",
                    Name = "ENG - ACTIVCE BED BUG LURE 12/PK (12/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "845710",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "BOX SPRING ENCASEMENT FULL 54X77.5X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885200",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "BOX SPRING ENCASEMENT HOTEL KING 36X82X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885201",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "BOX SPRING ENCASEMENT QUEEN 60X80X9X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885202",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "BOX SPRING ENCASEMENT TWIN 39X77.5\"X9\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885203",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS DOUBLE XL PREMIUM D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792883",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS DOUBLE XL PREMIUM PLUS D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792902",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS GRAND LIT PREMIUM PLUS D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792890",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS GRAND LIT XL PREMIUM D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792878",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS GRAND LIT XL PREMIUM D’ORKIN (16 À 22 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792884",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS GRAND LIT XL PREMIUM PLUS D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792889",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 85.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS JUMEAU XL PREMIUM D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792882",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS JUMEAU XL PREMIUM PLUS D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792900",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS TRÈS GRAND LIT (HOTEL) XL PREMIUM D’ORKIN (10 À 15 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792881",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE MATELAS TRÈS GRAND LIT PREMIUM PLUS D’ORKIN (16 À 22 PO.)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792905",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 120.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE SOMMIER GRAND LIT XL PREMIUM D’ORKIN",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793074",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE SOMMIER LIT DOUBLE XL PREMIUM D’ORKIN",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793077",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE SOMMIER LIT JUMEAU XL PREMIUM D’ORKIN",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793076",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE SOMMIER TRÈS GRAND LIT (HOTEL) XL PREMIUM D’ORKIN",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793075",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE-OREILLER GRAND LIT",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793078",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "COUVRE-OREILLER TRÈS GRAND LIT",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793079",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - CRIB ENCASEMENT PREMIUM (12/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793107",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - FURNITURE CHAIR ENCASEMENT MD",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793088",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 155.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - FURNITURE LOVE SEAT ENCASEMENT LG (6/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793090",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 230.00,
                    OrkinPrice = 230.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - FURNITURE SOFA BED ENCASEMENT XL (6/CS)",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "793091",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - MATTRESS ENCASEMENT FULL XL 16-22\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792888",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - MATTRESS ENCASEMENT KING 10-15\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792880",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ENG - MATTRESS ENCASEMENT TWIN XL 16-22\" PREMIUM",
                    Vendor = "GBS ENTERPRISES, LLC",
                    ProductId = "792887",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT CRIB 28X52X7 (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885209",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT FULL PLUS 54X77.5X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885204",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT HOTEL KING 72X82X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885205",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT KING 78X80X9\"-15\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885206",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT QUEEN 60X80X9\"-15\" (10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885207",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "MATTRESS ENCASEMENT TWIN PLUS 39X77.5X9-15\"(10/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885208",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: COUVRES",
                    Name = "ZIPPERED PILLOW COVER QUEEN 2/BG 20X30\" (50/CS)",
                    Vendor = "AMCAN",
                    ProductId = "885210",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: INSECTICIDE",
                    Name = "AÉROSOL POUR PUNAISES DE LIT ONGUARD - DOMESTIQUE",
                    Vendor = "UR-CAN INC.",
                    ProductId = "800007",
                    PCPNum = "31515",
                    UOM = "CN",
                    OrkinUOM = "CN",
                    Price = 15.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "BARRE D’ALIMENTATION CONTRE PUNAISES DE LIT AVEC GLUAU (ATTRACTIF)",
                    Vendor = "BEAPCO",
                    ProductId = "789862",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - BED BUG DEFENDER (12/BX)",
                    Vendor = "INNOVATIVE PEST PRODUCT INC.",
                    ProductId = "784559",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - BED BUG MOAT (18/CS)",
                    Vendor = "UPPER CANADA ORGANIC PR",
                    ProductId = "781283",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - BED BUG POWERBAR CO2 GENERATOR",
                    Vendor = "BEAPCO",
                    ProductId = "799635",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - BLACKOUT BED BUG TRAP 16/PK (4/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "846837",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - PRO-PEST BED BUG MONITOR PRO BULK BOX 36/PK 4/BX",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789405",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 490.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - PYRAMID PITFALL TRAP 24/PK (6/CS)",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "806149",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "ENG - SLIDER BED BUG MONITOR (96/CS)",
                    Vendor = "AP&G",
                    ProductId = "789406",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "GLUAU DE REMPLACEMENT AVEC ATTRACTIF POUR BARRE D’ALIMENTATION",
                    Vendor = "BEAPCO",
                    ProductId = "789863",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: PUNAISES DE LIT: MONITEURS",
                    Name = "MONITEUR À PUNAISES DE LIT SENSCI VOLCANO",
                    Vendor = "BEDBUG CENTRAL",
                    ProductId = "794237",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP",
                    Name = "ENG - CIDETRAK IMM (REGULAR DISPENSER) 36/PK PCP#32161",
                    Vendor = "TRECE, INC",
                    ProductId = "795967",
                    PCPNum = "32161",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 475.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP",
                    Name = "ENG - IDETRAK IMM ADHESIVE HOOKS (10/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "800265",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP",
                    Name = "PIÈGE DIAMOND  (AUCUN ATTRACTIF)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782065",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ATTRACTIFS POUR PYRALES 10/PAQUET - COOPER MILL",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782059",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - MOTH SUPPRESSION ATTRACT LURES",
                    Vendor = "INSECT LIMITED, INC.",
                    ProductId = "782509",
                    PCPNum = "",
                    UOM = "JR",
                    OrkinUOM = "JR",
                    Price = 115.00,
                    OrkinPrice = 115.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - RED & CONFUSED FLOUR BEETLE LURE TRAP (10/PK)",
                    Vendor = "INSECT LIMITED, INC.",
                    ProductId = "781394",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - STORGARD CIGARETTE BEETLE LURES (25/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "793883",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - STORGARD CONFUSED AND RED FLOUR BETTLE LURES (25/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "806139",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 160.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - STORGARD II TRAPS WITHOUT LURES (100/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "793744",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 375.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - STORGARD KHAPRA AND WAREHOUSE BETTLE LURES (25/CS)",
                    Vendor = "TRECE, INC",
                    ProductId = "806138",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - STORGARD WEBBING CLOTHES MOTH LURE (25/PK)",
                    Vendor = "TRECE, INC",
                    ProductId = "793881",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - XLURE MST RTU MULTI-SPECIES TRAP CARTRIDGES (10/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789740",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - XLURE MULTI-SPECIES BEETLE MONITORING TRAP (10/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "789739",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - XLURE RTU INSPECTOR PHER MONITORING TRAPS (100/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781263",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ENG - XLURE RTU PHEROMONE MONITOR SYSTEM 6/BG (4/CS)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781265",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 9.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "IMM+4 PIÈGES 6/TROUSSE",
                    Vendor = "TRECE, INC",
                    ProductId = "782784",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "PHÉROMONE POUR PYRALES(PIÈGE + ATTRACTIF) - COOPER MILL (CHACUN)",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782058",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "PK",
                    Price = 80.00,
                    OrkinPrice = 80.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "PIÈGE CFB/RFB AVEC DOME  5 PIÈGES",
                    Vendor = "TRECE, INC",
                    ProductId = "781133",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "PIÈGE ULTRA-COMBI QC PYRALES ET COLÉOPTÈRES",
                    Vendor = "TRECE, INC",
                    ProductId = "794030",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "PIÈGE XLURE RTU COMBO",
                    Vendor = "J F OAKES LLC",
                    ProductId = "781264",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "RECHARGE D’APPÂT POUR PIÈGE CFB/RFB DOME",
                    Vendor = "TRECE, INC",
                    ProductId = "797030",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "TROUSSE POUR LASIODERME DU TABAC",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782069",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "TROUSSE POUR TEIGNE DES VÊTEMENTS",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782072",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "TROUSSE POUR TRIBOLIUM DE LA FARINE",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782062",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "TROUSSE POUR TROGODERME DES ENTREPÔTS",
                    Vendor = "DISTRIBUTIONS SOLIDA INC.",
                    ProductId = "782061",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 90.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: SPP: MONITEURS",
                    Name = "ULTRA-COMBI QUCK CHANGE DOME PAQUET DE 6",
                    Vendor = "TRECE, INC",
                    ProductId = "793742",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "EA",
                    Price = 105.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: TERMITES: MONITEURS",
                    Name = "ENG - TERMITE MONITOR (48/CS)",
                    Vendor = "B&G EQUIPMENT",
                    ProductId = "790639",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "INSECTES: TIQUES",
                    Name = "ENG - TICK CONTROL TUBES 48/BX (8/CS)",
                    Vendor = "THERMACELL REPELLENTS",
                    ProductId = "805464",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 165.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: CHAUVES-SOURIS: PIÈGES",
                    Name = "BATCONE",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "782119",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "ENG - RACCOON ONE WAY DOOR 10\"X8\"X1\"",
                    Vendor = "RNS TRADING GROUP",
                    ProductId = "799146",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 70.00,
                    OrkinPrice = 70.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "ENG - THE GIANT DESTROYER SUPER GASSER 4/PK (12/CS) PCP#12269",
                    Vendor = "ATLAS CHEMICAL CORP",
                    ProductId = "791972",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "PIÈGE TOMAHAWK ONE WAY DOOR 10 PO.  X 4 PO.  X 4 PO.",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781739",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 60.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "PIÈGE TOMAHAWK ONE WAY DOOR 10 PO.  X 8 PO. X 8 PO.",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781741",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "PIÈGE TOMAHAWK ONE WAY DOOR 10 PO. X 6 PO. X 6 PO.",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "781740",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE",
                    Name = "PIÈGE TOMAHAWK ONE WAY DOOR 11 PO. X 3 PO.  X 3 PO.",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "788053",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: ÉQUIPEMENT",
                    Name = "ENG - TOMAHAWK DUAL RELEASE CATCH POLE 5'",
                    Vendor = "TOMAHAWK LIVE TRAP LLC",
                    ProductId = "788048",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: EXCLUSION",
                    Name = "ENG - WALL-E-COVER DEEP DRYER COVER - WHITE",
                    Vendor = "MMC DESIGN CONCEPTS INC",
                    ProductId = "806043",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 75.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: EXCLUSION",
                    Name = "ENG - WALL-E-COVER ROOF VENT COVER - EXPRESSO",
                    Vendor = "MMC DESIGN CONCEPTS INC",
                    ProductId = "806137",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "ENG - TALPIRID MOLE TRAP (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "795010",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 48.00,
                    OrkinPrice = 48.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "GOPHER HAWK TRAP (12/CS)",
                    Vendor = "MEISSNER INDUSTRIAL CO INC",
                    ProductId = "883609",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "GOPHER HAWK TRAPPING SET (6/CS)",
                    Vendor = "MEISSNER INDUSTRIAL CO INC",
                    ProductId = "883612",
                    PCPNum = "",
                    UOM = "SET",
                    OrkinUOM = "SET",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "PIÈGE À RONGEUR HAVAHART 16 PO. X 6 PO. X 6.5 PO.",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781580",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "PIÈGE HAVAHART 1025  (PETIT) 17,5 PO. X 5,75 PO. X 7,25 PO.",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "782151",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 55.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "PIÈGE HAVAHART 1078 (MOYEN) 24 PO. X 7 PO. X 7 PO.",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781609",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 89.00,
                    OrkinPrice = 89.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "PIÈGE HAVAHART 1079 RATON LAVEUR (GRAND) 32 PO. X 10 PO. X 12 PO.",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781610",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: FAUNE: PIÈGES",
                    Name = "PIÈGE HAVAHART EASY SET (MOYEN) 32 PO. X 11.75 PO. X 14.5 PO.",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781612",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 125.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: MOUFFETTES: PIÈGES",
                    Name = "ENG - SKUNK TRAP 30\" X 7\" X 8\"",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "794545",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: DETERRENTS",
                    Name = "ENG - BIRD FLITE 2 1/2\" (NARROW)",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781641",
                    PCPNum = "",
                    UOM = "FT",
                    OrkinUOM = "FT",
                    Price = 6.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: DETERRENTS",
                    Name = "ENG - BIRD FLITE 4 1/2\" (WIDE)",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781646",
                    PCPNum = "",
                    UOM = "FT",
                    OrkinUOM = "FT",
                    Price = 7.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: PIÈGES",
                    Name = "ENG - KAGE-ALL PIGEON TRAP 36\" X 18\" X 8\"",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781593",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: PIÈGES",
                    Name = "ENG - PIGEON TRAP WITH SHADE & 3.78L WATER BOTTLE",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "791875",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 425.00,
                    OrkinPrice = 425.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: PIÈGES",
                    Name = "ENG - PIGEON TRAP WITH SHADE, FOOD & WATER PANS",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "791866",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 240.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: PIÈGES",
                    Name = "ENG - SPARROW TRAP WITH FOOD & WATER 36\"X24\"X10\"",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "799111",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 460.00,
                    OrkinPrice = 460.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: PIÈGES",
                    Name = "ENG - SPARROW TRAP WITH TWO CHAMBER 8\"X12\"X16\"",
                    Vendor = "BIRD B GONE, INC",
                    ProductId = "802880",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 130.00,
                    OrkinPrice = 130.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: POINTES",
                    Name = "ENG - DURA-SPIKE EXTRA WIDE 8\" X 3\"",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781650",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OISEAUX / FAUNE: OISEAUX: POINTES",
                    Name = "ENG - DURA-SPIKE WIDE 5\" X 3\"",
                    Vendor = "BIRD BARRIER AMERICA",
                    ProductId = "781649",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 23.00,
                    OrkinPrice = 23.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "OTHERS",
                    Name = "ORKIN DOCUMENT CENTER (LOGBOOK/GM)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781294",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 180.00,
                    OrkinPrice = 180.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: ACTIZYME",
                    Name = "CONCENTRÉ ACTIZYME  4L - ORKIN",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "782707",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: ACTIZYME",
                    Name = "MOUSSE AÉROSOL ACTIZYME",
                    Vendor = "ROCKWELL LABS LTD",
                    ProductId = "782708",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 225.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: DÉSINFECTANT",
                    Name = "ENG - ZEP SPIRIT II RTU DETERGENT DISINFECTANT 1L (12/CS)",
                    Vendor = "AMREP",
                    ProductId = "804187",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: DÉSINFECTANT",
                    Name = "LINGETTES DÉSINFECTANTES STERIWIPES (160 LINGETTES/CONTENANT)",
                    Vendor = "TRILLIUM SALES GROUP INC.",
                    ProductId = "804783",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: DÉSINFECTANT",
                    Name = "VIREX  256  946 ML",
                    Vendor = "ROY TURK INDUSTRIAL",
                    ProductId = "781106",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 230.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "PRODUITS DE NETTOYAGE: MOUSSE",
                    Name = "ENG - PROFOAM PLATINUM 3.78L (4/CS)",
                    Vendor = "NPD PRODUCTS LTD.",
                    ProductId = "782076",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 110.00,
                    OrkinPrice = 110.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RATS: GLUAUX",
                    Name = "ENG - GLUE TRAY - RAT W/O PUTTY (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "803127",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "2PK",
                    Price = 125.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RATS: GLUAUX",
                    Name = "ENG - GLUE TRAY BLACK - RAT (48/CS)",
                    Vendor = "AP&G",
                    ProductId = "798705",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "PK",
                    Price = 110.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RATS: GLUAUX",
                    Name = "GLUAU POUR RAT",
                    Vendor = "AP&G",
                    ProductId = "780891",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RATS: GLUAUX",
                    Name = "GLUAU POUR RAT (GÉANT)",
                    Vendor = "AP&G",
                    ProductId = "780879",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RATS: PIÈGES",
                    Name = "PIÈGE POUR RAT EZ SET 621P",
                    Vendor = "AP&G",
                    ProductId = "790589",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 8.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: APPÂT",
                    Name = "APPÂT POUR RAT PROVOKE - ATTRACTIF",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781463",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: APPÂT",
                    Name = "APPÂT POUR SOURIS PROVOKE - ATTRACTIF",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781462",
                    PCPNum = "",
                    UOM = "BT",
                    OrkinUOM = "BT",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: APPÂT",
                    Name = "ENG - PRO-PEST RATS & MICE LURE 32CC SYRINGE (50/BX)",
                    Vendor = "J F OAKES LLC",
                    ProductId = "786893",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: DETERRENTS",
                    Name = "XCLUDER X-PLATE UNIVERSAL ESCUTCHEON PLATE (24/CS) 162861-UC-24",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "886202",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "KT",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "BAS DE PORTE XCLUDER 36 PO. À NIVELAGE AUTOMATIQUE EN ALUMINIUM",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802267",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "COUPE-BRISES XCLUDER RÉGULIER EN ALUMINIUM 36 PO 11101036-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846177",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 95.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "COUPE-BRISES XCLUDER RÉGULIER EN ALUMINIUM 48 PO 11101048-AL",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846312",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 110.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - RODENTSTOP RODENT PROOFING COMPOUND (340G/12OZ) (12/CS)",
                    Vendor = "PELGAR USA",
                    ProductId = "802039",
                    PCPNum = "",
                    UOM = "TU",
                    OrkinUOM = "TU",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - WEEP HOLE INSERT SS 2-¾\" 50/BX (8/CS)",
                    Vendor = "RID-O-MICE 2252859 ONT",
                    ProductId = "795966",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER FILL FABRIC STARTER KIT SHEARS,GLOVES & 4\"X10' ROLL162731",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "786436",
                    PCPNum = "",
                    UOM = "KT",
                    OrkinUOM = "KT",
                    Price = 65.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER FRYE INSPECTION TOOL (F.I.T) (25/PK)",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802844",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER LOW PROFILE DOCK SEAL KIT 4X4' RET+16' RUBBER 162570",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "846120",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 350.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER OVERHEAD DOOR RODENT SIDE SHIELD (2/PK) 162940",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806175",
                    PCPNum = "",
                    UOM = "PK",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER T RUBBER BOTTOM GARAGE DOOR SEAL 4\"X75' 162654-75",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806100",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 1825.00,
                    OrkinPrice = 1855.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 1½\"X25'562462-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806172",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 140.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 2\"X25' 562461-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806169",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 155.00,
                    OrkinPrice = 155.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD DOOR BRUSH SWEEP INSERT 3\"X25' 562463-25",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806168",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 195.00,
                    OrkinPrice = 195.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD ROLL-UP DOOR SEAL KIT 12'X4\" 162934",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805767",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 325.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD ROLL-UP DOOR SEAL KIT 8’X4” 162933",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805766",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 250.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT12'X4\" 1½\" 162973",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804738",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 340.00,
                    OrkinPrice = 340.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT12'X4\" 1¾\" 162974",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804737",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 300.00,
                    OrkinPrice = 300.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16’X4” 2\" 162978",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805450",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 475.00,
                    OrkinPrice = 475.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16'X4\" 1½\" 162976",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804736",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 430.00,
                    OrkinPrice = 430.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 OVERHEAD SECTIONAL DOOR SEAL KIT16'X4\" 1¾\" 162977",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "802989",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 445.00,
                    OrkinPrice = 445.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 1⅜”X1½” 562672-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "805866",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 38.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 1¾\"X1¾\" 562670-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806171",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 40.00,
                    OrkinPrice = 40.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 RETAINER 4'1\" L-SHAPED ALUMINUM 2\"X2\" 562676-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806170",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "ENG - XCLUDER X2 RETAINER 4'1\" T-SHAPED ALUMINUM 2\"X1⅝\" 562688-4",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "806173",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 38.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "JOINT D’ÉTANCHÉITÉ À CHAÎNE DE TRACTION  1,75 PO.- XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803895",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "JOINT D’ÉTANCHÉITÉ À CHAÎNE DE TRACTION 2 PO. - XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803896",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "JOINT D’ÉTANCHÉITÉ À CHAÎNE DE TRACTION 2,5 PO. - XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803897",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "JOINT D’ÉTANCHÉITÉ PORTE GARAGE 8 PIEDS X 2 PO. - XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804112",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 350.00,
                    OrkinPrice = 350.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "MAILLE EN CUIVRE - ROULEAU 100 PIEDS",
                    Vendor = "D & S SPECIALTY PRODUCTS INC.",
                    ProductId = "784484",
                    PCPNum = "",
                    UOM = "RL",
                    OrkinUOM = "RL",
                    Price = 100.00,
                    OrkinPrice = 100.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "MAILLE EN CUIVRE - ROULEAU 20 PIEDS",
                    Vendor = "D & S SPECIALTY PRODUCTS INC.",
                    ProductId = "784483",
                    PCPNum = "",
                    UOM = "RL",
                    OrkinUOM = "RL",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "TISSU DE REMBOURRAGE XCLUDER (MATÉRIEL D’EXCLUSION) ROULEAU 4 PO. X 10 PI.",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "798842",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 240.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "TROUSSE JOINT D’ÉTANCHÉITÉ PORTE GARAGE 8 PIEDS X 1,5 PO.  - XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "804870",
                    PCPNum = "",
                    UOM = "UN",
                    OrkinUOM = "EA",
                    Price = 185.00,
                    OrkinPrice = 185.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: EXCLUSION",
                    Name = "TROUSSE JOINT D’ÉTANCHÉITÉ PORTE GARAGE 8 PIEDS X 2 PO. - XCLUDER",
                    Vendor = "GLOBAL MATERIAL TECHNOLOGIES",
                    ProductId = "803519",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 215.00,
                    OrkinPrice = 215.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: GLUAUX",
                    Name = "ROULEAU CATCH ZONE PEST BOUNDARY",
                    Vendor = "AP&G",
                    ProductId = "802992",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 825.00,
                    OrkinPrice = 145.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - KETCH-ALL GLUEBOARDS (50/BX)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "785343",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - MULTI-CATCH - SOLID LID WHITE WITH ORKIN STICKERS (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "800667",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - MULTI-CATCH MINI - SOLID LID SILVER (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801181",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 125.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - MULTI-CATCH MINI - SOLID LID WHITE (12/CS)",
                    Vendor = "AP&G",
                    ProductId = "801182",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - PRO-KETCH MULTI CATCH MOUSE TRAP - CLEAR LID (12/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781529",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - PROTECTA EVO TUNNEL (6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "804748",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E COVER FOR MOUSE TRAP - BLACK (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794798",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E COVER FOR MOUSE TRAP - GREY (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794799",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E COVER FOR MOUSE TRAP - WHITE (6/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "794830",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 62.00,
                    OrkinPrice = 11.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E MOUSE TRAP (72/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781544",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 4.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E RAT TRAP",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "791012",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 7.00,
                    OrkinPrice = 7.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - SNAP-E RAT TRAP COVER (9/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "803930",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 29.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TIP-TRAP LIVE CAPTURE MOUSE TRAP RETAIL 6/BX(4/CS)",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781534",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 16.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TRAPPER 24/7 IQ MULTI CATCH MOUSE TRAP (4/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "806145",
                    PCPNum = "31969",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 235.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TRAPPER MAX GLUE TRAP (72/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781475",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TRAPPER MINI-REX MOUSE SNAP TRAP (24/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781473",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 2.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TRAPPER MONITOR & INSECT TRAP (100/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "799148",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 85.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - TRAPPER T-REX TRAP FOR RATS (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781472",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - VICTOR GLUE TRAPS MOUSE (72/BX)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781614",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "ENG - WIND-UP MULTIPLE CATCH MOUSE TRAP - WHITE (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "782086",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "GLUAU POUR TUNNEL TRAPPER PAQUET DE 2",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781478",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "PK",
                    Price = 165.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "MONITEUR À INSECTES EZ CONCEAL",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802993",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "MONITEUR À PARASITES TRAPPER (PLASTIQUE)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781461",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 8.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PIÈGE KETCHALL  - JT EATON",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "782223",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 300.00,
                    OrkinPrice = 27.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PIÈGE KETCHALL  - KNESS",
                    Vendor = "KNESS MFG CO., INC.",
                    ProductId = "781560",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 27.00,
                    OrkinPrice = 27.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PIÈGE SNAP TRAP POUR RAT (BOIS)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781621",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 4.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PIÈGE SNAP TRAP POUR SOURIS (BOIS)",
                    Vendor = "WOODSTREAM CANADA CORP",
                    ProductId = "781617",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PIÈGE TRAPPER 24/7 POUR SOURIS (TIN CAT EN PLASTIQUE)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781458",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PLAQUE DE COLLE TRAPPER (POUR 781458/781461)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781459",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 38.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PROTECTEUR POUR PIÈGE KETCHALL (MÉTAL)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781298",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 45.00,
                    OrkinPrice = 45.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PROTECTEUR POUR PIÈGE MINI TINCAT (MÉTAL)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "802252",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "PROTECTEUR POUR PIÈGE TINCAT (MÉTAL)",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781297",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: PIÈGES",
                    Name = "TUNNEL TRAPPER (PLASTIQUE)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781477",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: RODENTICIDE",
                    Name = "ENG - DETEX BLOX WITH LUMITRACK 4KG (2/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781949",
                    PCPNum = "",
                    UOM = "PL",
                    OrkinUOM = "PL",
                    Price = 90.00,
                    OrkinPrice = 90.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: RODENTICIDE",
                    Name = "ENG - HAWK ALL WEATHER BAIT CHUNX 0.8KG (6/CS)",
                    Vendor = "MOTOMCO INC",
                    ProductId = "793428",
                    PCPNum = "26595",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 28.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT MHOUSE REMPLISSABLE AVEC APPÂT - LIPHATECH (PACKET DE 5)",
                    Vendor = "LIPHATECH INC",
                    ProductId = "804572",
                    PCPNum = "30799",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT POUR RAT (CLÉ GRISE)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780732",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT POUR SOURIS",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780733",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT PROTECTA EVO CIRCUIT",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "785954",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT PROTECTA LANDSCAPE (GRANITE)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781456",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT PROTECTA LANDSCAPE (GRÈS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781879",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT PROTECTA POUR RAT",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781468",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 175.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "BOÎTE D’APPÂT PROTECTA SIDEKICK",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781469",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 20.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - EZ KLEAN LIQUID FEEDER",
                    Vendor = "VM PRODUCTS",
                    ProductId = "793727",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 12.00,
                    OrkinPrice = 12.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - EZ SECURED RODENT BAIT STATION",
                    Vendor = "VM PRODUCTS",
                    ProductId = "782230",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - EZ SECURED RODENT BAIT STATION - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "804475",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 25.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - EZ STATION SERVICE TRAY (60/BX)",
                    Vendor = "VM PRODUCTS",
                    ProductId = "806136",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 110.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - LIQUA-TOX BAIT DISPENSER",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "800092",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 7.50,
                    OrkinPrice = 7.50,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - MBS1 INSECT TRAY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "802428",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 1.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - MBS1 MOUSE BAIT STATION (12/BX) - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780737",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 30.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA EVO EXPRESS RAT BAIT STATION W/ WEIGHT - BLACK",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "783636",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 35.00,
                    OrkinPrice = 35.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA EVO EXPRESS RAT BAIT STATION W/ WEIGHT - GRAY",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "802150",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 50.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA EVO LANDSCAPE BAIT STATION STONE WEIGHT (2/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "799817",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 120.00,
                    OrkinPrice = 65.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA LP RAT BAIT STATION - (BLACK 6/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781436",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 25.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA MICRO MOUSE BAIT STATION (12/BX)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "785254",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 22.00,
                    OrkinPrice = 2.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA MOUSE BAIT STATION (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781467",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 10.00,
                    OrkinPrice = 10.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA RTU MOUSE BAIT STATION (12/CS)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781464",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 55.00,
                    OrkinPrice = 5.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - PROTECTA SCREWS (100/BG)",
                    Vendor = "BELL LABORATORIES INC",
                    ProductId = "781466",
                    PCPNum = "",
                    UOM = "BG",
                    OrkinUOM = "EA",
                    Price = 75.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - STRONGBOX BAIT STATION BLACK (12/CS)",
                    Vendor = "J.T. EATON CO., INC.",
                    ProductId = "793418",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 325.00,
                    OrkinPrice = 30.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - TOMCAT MOUSE KILLER BAIT STATION 4/BX (12/CS) 76840 PCP#30757",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792075",
                    PCPNum = "30757",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 150.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - TOMCAT MOUSE KILLER REFILL BAIT STATION (8/CS) 76878 PCP#30657",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792076",
                    PCPNum = "306757",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "ENG - TOMCAT RAT KILLER DISP BAIT STATION BAIT (4/CS) 76880 PCP#31969",
                    Vendor = "MOTOMCO INC",
                    ProductId = "792077",
                    PCPNum = "30657",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 20.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "MBS+ 2 BLOCK STATION (48/CS) - RED KEY",
                    Vendor = "VM PRODUCTS",
                    ProductId = "885173",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 140.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.00
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "PLAQUE D’ANCRAGE POUR BOÎTE D’APPÂT",
                    Vendor = "R.E. SKYVINGTON & ASSOC",
                    ProductId = "781296",
                    PCPNum = "",
                    UOM = "ST",
                    OrkinUOM = "EA",
                    Price = 135.00,
                    OrkinPrice = 6.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "STATION D’APPÂT POUR LES RATS (CLÉ ROUGE) REMPLACEMENT SEULEMENT",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780736",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 80.00,
                    OrkinPrice = 15.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: RONGEURS: STATION D'APPÂT",
                    Name = "STATION D’APPÂT POUR RATS (SUR BLOC) (CLÉ ROUGE) REMPLACEMENT SEULEMENT",
                    Vendor = "VM PRODUCTS",
                    ProductId = "780735",
                    PCPNum = "",
                    UOM = "PA",
                    OrkinUOM = "EA",
                    Price = 1225.00,
                    OrkinPrice = 21.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "ENG - GLUE TRAY - MOUSE (96/CS)",
                    Vendor = "AP&G",
                    ProductId = "798366",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "ENG - GLUEBOARD - MOUSE PEANUT SCENT (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "784018",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "ENG - GLUEBOARD FOR SLIM MULTI-CATCH MOUSE TRAP (72/BX)",
                    Vendor = "AP&G",
                    ProductId = "788528",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "GLUAU POUR CHAMBRE FROIDE/RÉFRIGÉRÉE (PAQUET DE 2)",
                    Vendor = "AP&G",
                    ProductId = "780880",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "2PK",
                    Price = 150.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "GLUAU SOURIS ET INSECTE",
                    Vendor = "AP&G",
                    ProductId = "780890",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "GLUAUX MULTICATCH  (INODORE)",
                    Vendor = "AP&G",
                    ProductId = "787099",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: GLUAUX",
                    Name = "PLAQUE DE COLLE PRISES MULTIPLES (ODEUR D’ARACHIDES - NON ALLERGÈNE)",
                    Vendor = "AP&G",
                    ProductId = "784426",
                    PCPNum = "",
                    UOM = "BX",
                    OrkinUOM = "EA",
                    Price = 60.00,
                    OrkinPrice = 1.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE MULTI-CATCH (TINCAT) BLANC",
                    Vendor = "AP&G",
                    ProductId = "801123",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE MULTI-CATCH (TINCAT) MÉTAL",
                    Vendor = "AP&G",
                    ProductId = "801124",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 200.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE MULTI-CATCH (TINCAT) MÉTAL COUVERCLE TRANSPARENT",
                    Vendor = "AP&G",
                    ProductId = "800708",
                    PCPNum = "",
                    UOM = "EA",
                    OrkinUOM = "EA",
                    Price = 18.00,
                    OrkinPrice = 18.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE MULTI-CATCH MINI (TINCAT) BLANC",
                    Vendor = "AP&G",
                    ProductId = "800668",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE MULTI-CATCH MINI (TINCAT) MÉTAL",
                    Vendor = "AP&G",
                    ProductId = "801180",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 145.00,
                    OrkinPrice = 13.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "RONGEURS: SOURIS: PIÈGES",
                    Name = "PIÈGE POUR SOURIS EZ SET 605P",
                    Vendor = "AP&G",
                    ProductId = "791529",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 65.00,
                    OrkinPrice = 3.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHIMIQUE",
                    Name = "ENG - SOAK TANK - ALUMINUM SAFE",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "787535",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 250.00,
                    OrkinPrice = 50.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHIMIQUE",
                    Name = "ENG - SOAK TANK CONCENTRATE (2X5.67L)",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "782469",
                    PCPNum = "",
                    UOM = "CS",
                    OrkinUOM = "EA",
                    Price = 180.00,
                    OrkinPrice = 95.00,
                    PercentOffForNational = 0.10
                },
                new Product()
                {
                    Category = "SOAK TANK: CHIMIQUE",
                    Name = "ENG - SOAK TANK NEUTRALIZER 3.78L",
                    Vendor = "ISM RESTAURANT SERVICES",
                    ProductId = "781744",
                    PCPNum = "",
                    UOM = "JG",
                    OrkinUOM = "JG",
                    Price = 90.00,
                    OrkinPrice = 90.00,
                    PercentOffForNational = 0.10
                }
            }

        };
    }
}
