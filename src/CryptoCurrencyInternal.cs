using System.Collections.Generic;

namespace CryptoCurrencies
{
    internal static class CryptoCurrencyInternal
    {
        #region Define

        private static readonly CryptoCurrency INVALID = new CryptoCurrency();
        private static readonly CryptoCurrency BTC = new CryptoCurrency("BTC", "Bitcoin", true, false, true, 0, "m/44’/0’/0’/0/0", "m/44’/0’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTCTEST = new CryptoCurrency("BTCTEST", "Bitcoin", false, true, true, 0, "m/44’/0’/0’/0/0", "m/44’/0’/0’/{0}/{1}");
        private static readonly CryptoCurrency LTC = new CryptoCurrency("LTC", "Litecoin", true, false, true, 2, "m/44’/2’/0’/0/0", "m/44’/2’/0’/{0}/{1}");
        private static readonly CryptoCurrency LTCTEST = new CryptoCurrency("LTCTEST", "Litecoin", false, true, true, 2, "m/44’/2’/0’/0/0", "m/44’/2’/0’/{0}/{1}");
        private static readonly CryptoCurrency DOGE = new CryptoCurrency("DOGE", "Dogecoin", true, false, false, 3, "m/44’/3’/0’/0/0", "m/44’/3’/0’/{0}/{1}");
        private static readonly CryptoCurrency DOGETEST = new CryptoCurrency("DOGETEST", "Dogecoin", false, true, false, 3, "m/44’/3’/0’/0/0", "m/44’/3’/0’/{0}/{1}");
        private static readonly CryptoCurrency RDD = new CryptoCurrency("RDD", "Reddcoin", true, false, false, 4, "m/44’/4’/0’/0/0", "m/44’/4’/0’/{0}/{1}");
        private static readonly CryptoCurrency DASH = new CryptoCurrency("DASH", "Dash", true, false, false, 5, "m/44’/5’/0’/0/0", "m/44’/5’/0’/{0}/{1}");
        private static readonly CryptoCurrency DASHTEST = new CryptoCurrency("DASHTEST", "Dash", false, true, false, 5, "m/44’/5’/0’/0/0", "m/44’/5’/0’/{0}/{1}");
        private static readonly CryptoCurrency PPC = new CryptoCurrency("PPC", "Peercoin", true, false, false, 6, "m/44’/6’/0’/0/0", "m/44’/6’/0’/{0}/{1}");
        private static readonly CryptoCurrency NMC = new CryptoCurrency("NMC", "Namecoin", true, false, false, 7, "m/44’/7’/0’/0/0", "m/44’/7’/0’/{0}/{1}");
        private static readonly CryptoCurrency FTC = new CryptoCurrency("FTC", "Feathercoin", true, false, false, 8, "m/44’/8’/0’/0/0", "m/44’/8’/0’/{0}/{1}");
        private static readonly CryptoCurrency BLK = new CryptoCurrency("BLK", "Blackcoin", true, false, false, 10, "m/44’/10’/0’/0/0", "m/44’/10’/0’/{0}/{1}");
        private static readonly CryptoCurrency NSR = new CryptoCurrency("NSR", "NuShares", true, false, false, 11, "m/44’/11’/0’/0/0", "m/44’/11’/0’/{0}/{1}");
        private static readonly CryptoCurrency NBT = new CryptoCurrency("NBT", "NuBits", true, false, false, 12, "m/44’/12’/0’/0/0", "m/44’/12’/0’/{0}/{1}");
        private static readonly CryptoCurrency MZC = new CryptoCurrency("MZC", "Mazacoin", true, false, false, 13, "m/44’/13’/0’/0/0", "m/44’/13’/0’/{0}/{1}");
        private static readonly CryptoCurrency VIA = new CryptoCurrency("VIA", "Viacoin", true, false, true, 14, "m/44’/14’/0’/0/0", "m/44’/14’/0’/{0}/{1}");
        private static readonly CryptoCurrency VIATEST = new CryptoCurrency("VIATEST", "Viacoin", false, true, true, 14, "m/44’/14’/0’/0/0", "m/44’/14’/0’/{0}/{1}");
        private static readonly CryptoCurrency RBY = new CryptoCurrency("RBY", "Rubycoin", true, false, false, 16, "m/44’/16’/0’/0/0", "m/44’/16’/0’/{0}/{1}");
        private static readonly CryptoCurrency GRS = new CryptoCurrency("GRS", "Groestl Coin", true, false, true, 17, "m/44’/17’/0’/0/0", "m/44’/17’/0’/{0}/{1}");
        private static readonly CryptoCurrency GRSTEST = new CryptoCurrency("GRSTEST", "Groestl Coin", false, true, true, 17, "m/44’/17’/0’/0/0", "m/44’/17’/0’/{0}/{1}");
        private static readonly CryptoCurrency DGC = new CryptoCurrency("DGC", "Digitalcoin", true, false, false, 18, "m/44’/18’/0’/0/0", "m/44’/18’/0’/{0}/{1}");
        private static readonly CryptoCurrency CCN = new CryptoCurrency("CCN", "Cannacoin", true, false, false, 19, "m/44’/19’/0’/0/0", "m/44’/19’/0’/{0}/{1}");
        private static readonly CryptoCurrency DGB = new CryptoCurrency("DGB", "Digi Byte", true, false, true, 20, "m/44’/20’/0’/0/0", "m/44’/20’/0’/{0}/{1}");
        private static readonly CryptoCurrency MONA = new CryptoCurrency("MONA", "Monacoin", true, false, true, 22, "m/44’/22’/0’/0/0", "m/44’/22’/0’/{0}/{1}");
        private static readonly CryptoCurrency CLAM = new CryptoCurrency("CLAM", "Clams", true, false, false, 23, "m/44’/23’/0’/0/0", "m/44’/23’/0’/{0}/{1}");
        private static readonly CryptoCurrency NEOS = new CryptoCurrency("NEOS", "Neoscoin", true, false, false, 25, "m/44’/25’/0’/0/0", "m/44’/25’/0’/{0}/{1}");
        private static readonly CryptoCurrency JBS = new CryptoCurrency("JBS", "Jumbucks", true, false, false, 26, "m/44’/26’/0’/0/0", "m/44’/26’/0’/{0}/{1}");
        private static readonly CryptoCurrency VTC = new CryptoCurrency("VTC", "Vertcoin", true, false, true, 28, "m/44’/28’/0’/0/0", "m/44’/28’/0’/{0}/{1}");
        private static readonly CryptoCurrency VASH = new CryptoCurrency("VASH", "Virtual Cash", true, false, false, 33, "m/44’/33’/0’/0/0", "m/44’/33’/0’/{0}/{1}");
        private static readonly CryptoCurrency CDN = new CryptoCurrency("CDN", "Canada eCoin", true, false, false, 34, "m/44’/34’/0’/0/0", "m/44’/34’/0’/{0}/{1}");
        private static readonly CryptoCurrency SDC = new CryptoCurrency("SDC", "Shadow Cash", true, false, false, 35, "m/44’/35’/0’/0/0", "m/44’/35’/0’/{0}/{1}");
        private static readonly CryptoCurrency SDCTEST = new CryptoCurrency("SDCTEST", "Shadow Cash", false, true, false, 35, "m/44’/35’/0’/0/0", "m/44’/35’/0’/{0}/{1}");
        private static readonly CryptoCurrency EMC2 = new CryptoCurrency("EMC2", "Einsteinium", true, false, false, 41, "m/44’/41’/0’/0/0", "m/44’/41’/0’/{0}/{1}");
        private static readonly CryptoCurrency POSW = new CryptoCurrency("POSW", "Posw Coin", true, false, false, 47, "m/44’/47’/0’/0/0", "m/44’/47’/0’/{0}/{1}");
        private static readonly CryptoCurrency GCR = new CryptoCurrency("GCR", "GCR Coin", true, false, false, 49, "m/44’/49’/0’/0/0", "m/44’/49’/0’/{0}/{1}");
        private static readonly CryptoCurrency NVC = new CryptoCurrency("NVC", "Novacoin", true, false, false, 50, "m/44’/50’/0’/0/0", "m/44’/50’/0’/{0}/{1}");
        private static readonly CryptoCurrency AC = new CryptoCurrency("AC", "Asiacoin", true, false, false, 51, "m/44’/51’/0’/0/0", "m/44’/51’/0’/{0}/{1}");
        private static readonly CryptoCurrency EDRC = new CryptoCurrency("EDRC", "EDR Coin", true, false, false, 56, "m/44’/56’/0’/0/0", "m/44’/56’/0’/{0}/{1}");
        private static readonly CryptoCurrency SYS = new CryptoCurrency("SYS", "Syscoin", true, false, true, 57, "m/44’/57’/0’/0/0", "m/44’/57’/0’/{0}/{1}");
        private static readonly CryptoCurrency SLR = new CryptoCurrency("SLR", "Solarcoin", true, false, false, 58, "m/44’/58’/0’/0/0", "m/44’/58’/0’/{0}/{1}");
        private static readonly CryptoCurrency SMLY = new CryptoCurrency("SMLY", "Smileycoin", true, false, false, 59, "m/44’/59’/0’/0/0", "m/44’/59’/0’/{0}/{1}");
        private static readonly CryptoCurrency ETH = new CryptoCurrency("ETH", "Ethereum", true, false, true, 60, "m/44’/60’/0’/0/0", "m/44’/60’/0’/{0}/{1}");
        private static readonly CryptoCurrency PSB = new CryptoCurrency("PSB", "Pesobit", true, false, false, 62, "m/44’/62’/0’/0/0", "m/44’/62’/0’/{0}/{1}");
        private static readonly CryptoCurrency SLM = new CryptoCurrency("SLM", "Slimcoin", true, false, false, 63, "m/44’/63’/0’/0/0", "m/44’/63’/0’/{0}/{1}");
        private static readonly CryptoCurrency SLMTEST = new CryptoCurrency("SLMTEST", "Slimcoin", false, true, false, 63, "m/44’/63’/0’/0/0", "m/44’/63’/0’/{0}/{1}");
        private static readonly CryptoCurrency XBC = new CryptoCurrency("XBC", "Bitcoin Plus", true, false, false, 65, "m/44’/65’/0’/0/0", "m/44’/65’/0’/{0}/{1}");
        private static readonly CryptoCurrency IOP = new CryptoCurrency("IOP", "Internet Of People", true, false, false, 66, "m/44’/66’/0’/0/0", "m/44’/66’/0’/{0}/{1}");
        private static readonly CryptoCurrency INSN = new CryptoCurrency("INSN", "Insane Coin", true, false, false, 68, "m/44’/68’/0’/0/0", "m/44’/68’/0’/{0}/{1}");
        private static readonly CryptoCurrency OK = new CryptoCurrency("OK", "OK Cash", true, false, false, 69, "m/44’/69’/0’/0/0", "m/44’/69’/0’/{0}/{1}");
        private static readonly CryptoCurrency BRIT = new CryptoCurrency("BRIT", "Brit Coin", true, false, false, 70, "m/44’/70’/0’/0/0", "m/44’/70’/0’/{0}/{1}");
        private static readonly CryptoCurrency CMP = new CryptoCurrency("CMP", "Compcoin", true, false, false, 71, "m/44’/71’/0’/0/0", "m/44’/71’/0’/{0}/{1}");
        private static readonly CryptoCurrency BELA = new CryptoCurrency("BELA", "Bela Coin", true, false, false, 73, "m/44’/73’/0’/0/0", "m/44’/73’/0’/{0}/{1}");
        private static readonly CryptoCurrency FJC = new CryptoCurrency("FJC", "Fuji Coin", true, false, true, 75, "m/44’/75’/0’/0/0", "m/44’/75’/0’/{0}/{1}");
        private static readonly CryptoCurrency XVG = new CryptoCurrency("XVG", "Verge Currency", true, false, false, 77, "m/44’/77’/0’/0/0", "m/44’/77’/0’/{0}/{1}");
        private static readonly CryptoCurrency CLUB = new CryptoCurrency("CLUB", "Club Coin", true, false, false, 79, "m/44’/79’/0’/0/0", "m/44’/79’/0’/{0}/{1}");
        private static readonly CryptoCurrency POT = new CryptoCurrency("POT", "Potcoin", true, false, false, 81, "m/44’/81’/0’/0/0", "m/44’/81’/0’/{0}/{1}");
        private static readonly CryptoCurrency GRC = new CryptoCurrency("GRC", "Gridcoin", true, false, false, 84, "m/44’/84’/0’/0/0", "m/44’/84’/0’/{0}/{1}");
        private static readonly CryptoCurrency AUR = new CryptoCurrency("AUR", "Auroracoin", true, false, false, 85, "m/44’/85’/0’/0/0", "m/44’/85’/0’/{0}/{1}");
        private static readonly CryptoCurrency IXC = new CryptoCurrency("IXC", "IX Coin", true, false, false, 86, "m/44’/86’/0’/0/0", "m/44’/86’/0’/{0}/{1}");
        private static readonly CryptoCurrency NLG = new CryptoCurrency("NLG", "Gulden", true, false, false, 87, "m/44’/87’/0’/0/0", "m/44’/87’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTA = new CryptoCurrency("BTA", "Bata", true, false, false, 89, "m/44’/89’/0’/0/0", "m/44’/89’/0’/{0}/{1}");
        private static readonly CryptoCurrency XMY = new CryptoCurrency("XMY", "Myriadcoin", true, false, false, 90, "m/44’/90’/0’/0/0", "m/44’/90’/0’/{0}/{1}");
        private static readonly CryptoCurrency BSD = new CryptoCurrency("BSD", "Bit Send", true, false, false, 91, "m/44’/91’/0’/0/0", "m/44’/91’/0’/{0}/{1}");
        private static readonly CryptoCurrency UNO = new CryptoCurrency("UNO", "Unobtanium", true, false, false, 92, "m/44’/92’/0’/0/0", "m/44’/92’/0’/{0}/{1}");
        private static readonly CryptoCurrency GAME = new CryptoCurrency("GAME", "Game Credits", true, false, false, 101, "m/44’/101’/0’/0/0", "m/44’/101’/0’/{0}/{1}");
        private static readonly CryptoCurrency STRAT = new CryptoCurrency("STRAT", "Stratis", true, false, false, 105, "m/44’/105’/0’/0/0", "m/44’/105’/0’/{0}/{1}");
        private static readonly CryptoCurrency STRATTEST = new CryptoCurrency("STRATTEST", "Stratis", false, true, false, 105, "m/44’/105’/0’/0/0", "m/44’/105’/0’/{0}/{1}");
        private static readonly CryptoCurrency NRO = new CryptoCurrency("NRO", "Neurocoin", true, false, false, 110, "m/44’/110’/0’/0/0", "m/44’/110’/0’/{0}/{1}");
        private static readonly CryptoCurrency USC = new CryptoCurrency("USC", "Ultimate Secure Cash", true, false, false, 112, "m/44’/112’/0’/0/0", "m/44’/112’/0’/{0}/{1}");
        private static readonly CryptoCurrency THC = new CryptoCurrency("THC", "Hempcoin", true, false, false, 113, "m/44’/113’/0’/0/0", "m/44’/113’/0’/{0}/{1}");
        private static readonly CryptoCurrency LINX = new CryptoCurrency("LINX", "Linx", true, false, false, 114, "m/44’/114’/0’/0/0", "m/44’/114’/0’/{0}/{1}");
        private static readonly CryptoCurrency ECN = new CryptoCurrency("ECN", "Ecoin", true, false, false, 115, "m/44’/115’/0’/0/0", "m/44’/115’/0’/{0}/{1}");
        private static readonly CryptoCurrency DNR = new CryptoCurrency("DNR", "Denarius", true, false, false, 116, "m/44’/116’/0’/0/0", "m/44’/116’/0’/{0}/{1}");
        private static readonly CryptoCurrency PINK = new CryptoCurrency("PINK", "Pinkcoin", true, false, false, 117, "m/44’/117’/0’/0/0", "m/44’/117’/0’/{0}/{1}");
        private static readonly CryptoCurrency ATOM = new CryptoCurrency("ATOM", "Atom", true, false, true, 118, "m/44’/118’/0’/0/0", "m/44’/118’/0’/{0}/{1}");
        private static readonly CryptoCurrency PIVX = new CryptoCurrency("PIVX", "Pivx", true, false, false, 119, "m/44’/119’/0’/0/0", "m/44’/119’/0’/{0}/{1}");
        private static readonly CryptoCurrency PIVXTEST = new CryptoCurrency("PIVXTEST", "Pivx", false, true, false, 119, "m/44’/119’/0’/0/0", "m/44’/119’/0’/{0}/{1}");
        private static readonly CryptoCurrency FLASH = new CryptoCurrency("FLASH", "Flashcoin", true, false, false, 120, "m/44’/120’/0’/0/0", "m/44’/120’/0’/{0}/{1}");
        private static readonly CryptoCurrency ZEN = new CryptoCurrency("ZEN", "Zencash", true, false, false, 121, "m/44’/121’/0’/0/0", "m/44’/121’/0’/{0}/{1}");
        private static readonly CryptoCurrency PUT = new CryptoCurrency("PUT", "Putincoin", true, false, false, 122, "m/44’/122’/0’/0/0", "m/44’/122’/0’/{0}/{1}");
        private static readonly CryptoCurrency VC = new CryptoCurrency("VC", "Vcash", true, false, false, 127, "m/44’/127’/0’/0/0", "m/44’/127’/0’/{0}/{1}");
        private static readonly CryptoCurrency NAV = new CryptoCurrency("NAV", "Navcoin", true, false, false, 130, "m/44’/130’/0’/0/0", "m/44’/130’/0’/{0}/{1}");
        private static readonly CryptoCurrency ZEC = new CryptoCurrency("ZEC", "Zcash", true, false, false, 133, "m/44’/133’/0’/0/0", "m/44’/133’/0’/{0}/{1}");
        private static readonly CryptoCurrency ZECTEST = new CryptoCurrency("ZECTEST", "Zcash", false, true, false, 133, "m/44’/133’/0’/0/0", "m/44’/133’/0’/{0}/{1}");
        private static readonly CryptoCurrency RBTC = new CryptoCurrency("RBTC", "RSK", true, false, false, 137, "m/44’/137’/0’/0/0", "m/44’/137’/0’/{0}/{1}");
        private static readonly CryptoCurrency RBTCTEST = new CryptoCurrency("RBTCTEST", "RSK", false, true, false, 137, "m/44’/137’/0’/0/0", "m/44’/137’/0’/{0}/{1}");
        private static readonly CryptoCurrency LBC = new CryptoCurrency("LBC", "LBRY Credits", true, false, false, 140, "m/44’/140’/0’/0/0", "m/44’/140’/0’/{0}/{1}");
        private static readonly CryptoCurrency KMD = new CryptoCurrency("KMD", "Komodo", true, false, false, 141, "m/44’/141’/0’/0/0", "m/44’/141’/0’/{0}/{1}");
        private static readonly CryptoCurrency BCH = new CryptoCurrency("BCH", "Bitcoin Cash", true, false, true, 145, "m/44’/145’/0’/0/0", "m/44’/145’/0’/{0}/{1}");
        private static readonly CryptoCurrency NEBL = new CryptoCurrency("NEBL", "Neblio", true, false, false, 146, "m/44’/146’/0’/0/0", "m/44’/146’/0’/{0}/{1}");
        private static readonly CryptoCurrency ZCL = new CryptoCurrency("ZCL", "ZClassic", true, false, false, 147, "m/44’/147’/0’/0/0", "m/44’/147’/0’/{0}/{1}");
        private static readonly CryptoCurrency ERC = new CryptoCurrency("ERC", "Europe Coin", true, false, false, 151, "m/44’/151’/0’/0/0", "m/44’/151’/0’/{0}/{1}");
        private static readonly CryptoCurrency DMD = new CryptoCurrency("DMD", "Diamond", true, false, false, 152, "m/44’/152’/0’/0/0", "m/44’/152’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTG = new CryptoCurrency("BTG", "Bitcoin Gold", true, false, true, 156, "m/44’/156’/0’/0/0", "m/44’/156’/0’/{0}/{1}");
        private static readonly CryptoCurrency TOA = new CryptoCurrency("TOA", "TOA Coin", true, false, false, 159, "m/44’/159’/0’/0/0", "m/44’/159’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTX = new CryptoCurrency("BTX", "Bitcore", true, false, true, 160, "m/44’/160’/0’/0/0", "m/44’/160’/0’/{0}/{1}");
        private static readonly CryptoCurrency VIVO = new CryptoCurrency("VIVO", "Vivo", true, false, false, 166, "m/44’/166’/0’/0/0", "m/44’/166’/0’/{0}/{1}");
        private static readonly CryptoCurrency FRST = new CryptoCurrency("FRST", "Firstcoin", true, false, false, 167, "m/44’/167’/0’/0/0", "m/44’/167’/0’/{0}/{1}");
        private static readonly CryptoCurrency HNC = new CryptoCurrency("HNC", "Helleniccoin", true, false, false, 168, "m/44’/168’/0’/0/0", "m/44’/168’/0’/{0}/{1}");
        private static readonly CryptoCurrency ONX = new CryptoCurrency("ONX", "Onix Coin", true, false, false, 174, "m/44’/174’/0’/0/0", "m/44’/174’/0’/{0}/{1}");
        private static readonly CryptoCurrency RVN = new CryptoCurrency("RVN", "Ravencoin", true, false, false, 175, "m/44’/175’/0’/0/0", "m/44’/175’/0’/{0}/{1}");
        private static readonly CryptoCurrency GBX = new CryptoCurrency("GBX", "Go Byte", true, false, false, 176, "m/44’/176’/0’/0/0", "m/44’/176’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTCZ = new CryptoCurrency("BTCZ", "BitcoinZ", true, false, false, 177, "m/44’/177’/0’/0/0", "m/44’/177’/0’/{0}/{1}");
        private static readonly CryptoCurrency NYC = new CryptoCurrency("NYC", "New York Coin", true, false, false, 179, "m/44’/179’/0’/0/0", "m/44’/179’/0’/{0}/{1}");
        private static readonly CryptoCurrency WC = new CryptoCurrency("WC", "Wincoin", true, false, false, 181, "m/44’/181’/0’/0/0", "m/44’/181’/0’/{0}/{1}");
        private static readonly CryptoCurrency MNX = new CryptoCurrency("MNX", "Minexcoin", true, false, false, 182, "m/44’/182’/0’/0/0", "m/44’/182’/0’/{0}/{1}");
        private static readonly CryptoCurrency CRAVE = new CryptoCurrency("CRAVE", "Crave", true, false, false, 186, "m/44’/186’/0’/0/0", "m/44’/186’/0’/{0}/{1}");
        private static readonly CryptoCurrency EXCL = new CryptoCurrency("EXCL", "Exclusive Coin", true, false, false, 190, "m/44’/190’/0’/0/0", "m/44’/190’/0’/{0}/{1}");
        private static readonly CryptoCurrency LYNX = new CryptoCurrency("LYNX", "Lynx", true, false, false, 191, "m/44’/191’/0’/0/0", "m/44’/191’/0’/{0}/{1}");
        private static readonly CryptoCurrency LCC = new CryptoCurrency("LCC", "Litecoin Cash", true, false, false, 192, "m/44’/192’/0’/0/0", "m/44’/192’/0’/{0}/{1}");
        private static readonly CryptoCurrency TRX = new CryptoCurrency("TRX", "Tron", true, false, false, 195, "m/44’/195’/0’/0/0", "m/44’/195’/0’/{0}/{1}");
        private static readonly CryptoCurrency KOBO = new CryptoCurrency("KOBO", "Kobocoin", true, false, false, 196, "m/44’/196’/0’/0/0", "m/44’/196’/0’/{0}/{1}");
        private static readonly CryptoCurrency HUSH = new CryptoCurrency("HUSH", "Hush", true, false, false, 197, "m/44’/197’/0’/0/0", "m/44’/197’/0’/{0}/{1}");
        private static readonly CryptoCurrency OMNI = new CryptoCurrency("OMNI", "Omni", true, false, false, 200, "m/44’/200’/0’/0/0", "m/44’/200’/0’/{0}/{1}");
        private static readonly CryptoCurrency OMNITEST = new CryptoCurrency("OMNITEST", "Omni", false, true, false, 200, "m/44’/200’/0’/0/0", "m/44’/200’/0’/{0}/{1}");
        private static readonly CryptoCurrency MONK = new CryptoCurrency("MONK", "Monkey Project", true, false, true, 214, "m/44’/214’/0’/0/0", "m/44’/214’/0’/{0}/{1}");
        private static readonly CryptoCurrency MEC = new CryptoCurrency("MEC", "Megacoin", true, false, false, 217, "m/44’/217’/0’/0/0", "m/44’/217’/0’/{0}/{1}");
        private static readonly CryptoCurrency BTDX = new CryptoCurrency("BTDX", "Bit Cloud", true, false, false, 218, "m/44’/218’/0’/0/0", "m/44’/218’/0’/{0}/{1}");
        private static readonly CryptoCurrency XAX = new CryptoCurrency("XAX", "Artax", true, false, false, 219, "m/44’/219’/0’/0/0", "m/44’/219’/0’/{0}/{1}");
        private static readonly CryptoCurrency ANON = new CryptoCurrency("ANON", "Anon", true, false, false, 220, "m/44’/220’/0’/0/0", "m/44’/220’/0’/{0}/{1}");
        private static readonly CryptoCurrency LTZ = new CryptoCurrency("LTZ", "LitecoinZ", true, false, false, 221, "m/44’/221’/0’/0/0", "m/44’/221’/0’/{0}/{1}");
        private static readonly CryptoCurrency XUEZ = new CryptoCurrency("XUEZ", "XUEZ", true, false, false, 225, "m/44’/225’/0’/0/0", "m/44’/225’/0’/{0}/{1}");
        private static readonly CryptoCurrency BSV = new CryptoCurrency("BSV", "Bitcoin SV", true, false, false, 236, "m/44’/236’/0’/0/0", "m/44’/236’/0’/{0}/{1}");
        private static readonly CryptoCurrency BST = new CryptoCurrency("BST", "Block Stamp", true, false, true, 254, "m/44’/254’/0’/0/0", "m/44’/254’/0’/{0}/{1}");
        private static readonly CryptoCurrency BOLI = new CryptoCurrency("BOLI", "Bolivarcoin", true, false, false, 278, "m/44’/278’/0’/0/0", "m/44’/278’/0’/{0}/{1}");
        private static readonly CryptoCurrency ONION = new CryptoCurrency("ONION", "Deep Onion", true, false, true, 305, "m/44’/305’/0’/0/0", "m/44’/305’/0’/{0}/{1}");
        private static readonly CryptoCurrency RPD = new CryptoCurrency("RPD", "Rapids", true, false, false, 320, "m/44’/320’/0’/0/0", "m/44’/320’/0’/{0}/{1}");
        private static readonly CryptoCurrency FIX = new CryptoCurrency("FIX", "FIX", true, false, false, 336, "m/44’/336’/0’/0/0", "m/44’/336’/0’/{0}/{1}");
        private static readonly CryptoCurrency FIXTEST = new CryptoCurrency("FIXTEST", "FIX", false, true, false, 336, "m/44’/336’/0’/0/0", "m/44’/336’/0’/{0}/{1}");
        private static readonly CryptoCurrency AYA = new CryptoCurrency("AYA", "Aryacoin", true, false, false, 357, "m/44’/357’/0’/0/0", "m/44’/357’/0’/{0}/{1}");
        private static readonly CryptoCurrency CPU = new CryptoCurrency("CPU", "CPU Chain", true, false, true, 363, "m/44’/363’/0’/0/0", "m/44’/363’/0’/{0}/{1}");
        private static readonly CryptoCurrency NIX = new CryptoCurrency("NIX", "NIX", true, false, true, 400, "m/44’/400’/0’/0/0", "m/44’/400’/0’/{0}/{1}");
        private static readonly CryptoCurrency SUGAR = new CryptoCurrency("SUGAR", "Sugarchain", true, false, true, 408, "m/44’/408’/0’/0/0", "m/44’/408’/0’/{0}/{1}");
        private static readonly CryptoCurrency SUGARTEST = new CryptoCurrency("SUGARTEST", "Sugarchain", false, true, true, 408, "m/44’/408’/0’/0/0", "m/44’/408’/0’/{0}/{1}");
        private static readonly CryptoCurrency AGM = new CryptoCurrency("AGM", "Argoneum", true, false, false, 421, "m/44’/421’/0’/0/0", "m/44’/421’/0’/{0}/{1}");
        private static readonly CryptoCurrency PHR = new CryptoCurrency("PHR", "Phore", true, false, false, 444, "m/44’/444’/0’/0/0", "m/44’/444’/0’/{0}/{1}");
        private static readonly CryptoCurrency THT = new CryptoCurrency("THT", "Thought AI", true, false, false, 502, "m/44’/502’/0’/0/0", "m/44’/502’/0’/{0}/{1}");
        private static readonly CryptoCurrency PRJ = new CryptoCurrency("PRJ", "Project Coin", true, false, false, 533, "m/44’/533’/0’/0/0", "m/44’/533’/0’/{0}/{1}");
        private static readonly CryptoCurrency SCRIBE = new CryptoCurrency("SCRIBE", "Scribe", true, false, false, 545, "m/44’/545’/0’/0/0", "m/44’/545’/0’/{0}/{1}");
        private static readonly CryptoCurrency XDC = new CryptoCurrency("XDC", "XinFin", true, false, true, 550, "m/44’/550’/0’/0/0", "m/44’/550’/0’/{0}/{1}");
        private static readonly CryptoCurrency LKR = new CryptoCurrency("LKR", "Lkrcoin", true, false, false, 557, "m/44’/557’/0’/0/0", "m/44’/557’/0’/{0}/{1}");
        private static readonly CryptoCurrency XWC = new CryptoCurrency("XWC", "Whitecoin", true, false, false, 559, "m/44’/559’/0’/0/0", "m/44’/559’/0’/{0}/{1}");
        private static readonly CryptoCurrency SLS = new CryptoCurrency("SLS", "Saluscoin", true, false, false, 572, "m/44’/572’/0’/0/0", "m/44’/572’/0’/{0}/{1}");
        private static readonly CryptoCurrency BEET = new CryptoCurrency("BEET", "Beetle Coin", true, false, false, 800, "m/44’/800’/0’/0/0", "m/44’/800’/0’/{0}/{1}");
        private static readonly CryptoCurrency TWINS = new CryptoCurrency("TWINS", "Twins", true, false, false, 970, "m/44’/970’/0’/0/0", "m/44’/970’/0’/{0}/{1}");
        private static readonly CryptoCurrency TWINSTEST = new CryptoCurrency("TWINSTEST", "Twins", false, true, false, 970, "m/44’/970’/0’/0/0", "m/44’/970’/0’/{0}/{1}");
        private static readonly CryptoCurrency DFC = new CryptoCurrency("DFC", "Defcoin", true, false, false, 1337, "m/44’/1337’/0’/0/0", "m/44’/1337’/0’/{0}/{1}");
        private static readonly CryptoCurrency QTUM = new CryptoCurrency("QTUM", "Qtum", true, false, true, 2301, "m/44’/2301’/0’/0/0", "m/44’/2301’/0’/{0}/{1}");
        private static readonly CryptoCurrency QTUMTEST = new CryptoCurrency("QTUMTEST", "Qtum", false, true, true, 2301, "m/44’/2301’/0’/0/0", "m/44’/2301’/0’/{0}/{1}");
        private static readonly CryptoCurrency CRP = new CryptoCurrency("CRP", "Crane Pay", true, false, true, 2304, "m/44’/2304’/0’/0/0", "m/44’/2304’/0’/{0}/{1}");
        private static readonly CryptoCurrency ELA = new CryptoCurrency("ELA", "Elastos", true, false, false, 2305, "m/44’/2305’/0’/0/0", "m/44’/2305’/0’/{0}/{1}");
        private static readonly CryptoCurrency BND = new CryptoCurrency("BND", "Blocknode", true, false, false, 2941, "m/44’/2941’/0’/0/0", "m/44’/2941’/0’/{0}/{1}");
        private static readonly CryptoCurrency BNDTEST = new CryptoCurrency("BNDTEST", "Blocknode", false, true, false, 2941, "m/44’/2941’/0’/0/0", "m/44’/2941’/0’/{0}/{1}");
        private static readonly CryptoCurrency AXE = new CryptoCurrency("AXE", "Axe", true, false, false, 4242, "m/44’/4242’/0’/0/0", "m/44’/4242’/0’/{0}/{1}");
        private static readonly CryptoCurrency NRG = new CryptoCurrency("NRG", "Energi", true, false, false, 9797, "m/44’/9797’/0’/0/0", "m/44’/9797’/0’/{0}/{1}");
        private static readonly CryptoCurrency SAFE = new CryptoCurrency("SAFE", "Safecoin", true, false, false, 19165, "m/44’/19165’/0’/0/0", "m/44’/19165’/0’/{0}/{1}");
        private static readonly CryptoCurrency STASH = new CryptoCurrency("STASH", "Stash", true, false, false, 49344, "m/44’/49344’/0’/0/0", "m/44’/49344’/0’/{0}/{1}");

        #endregion

        internal static CryptoCurrency GetCryptoCurrency(this string symbol)
        {
            return symbol switch
            {
                "BTC" => BTC,
                "BTCTEST" => BTCTEST,
                "LTC" => LTC,
                "LTCTEST" => LTCTEST,
                "DOGE" => DOGE,
                "DOGETEST" => DOGETEST,
                "RDD" => RDD,
                "DASH" => DASH,
                "DASHTEST" => DASHTEST,
                "PPC" => PPC,
                "NMC" => NMC,
                "FTC" => FTC,
                "BLK" => BLK,
                "NSR" => NSR,
                "NBT" => NBT,
                "MZC" => MZC,
                "VIA" => VIA,
                "VIATEST" => VIATEST,
                "RBY" => RBY,
                "GRS" => GRS,
                "GRSTEST" => GRSTEST,
                "DGC" => DGC,
                "CCN" => CCN,
                "DGB" => DGB,
                "MONA" => MONA,
                "CLAM" => CLAM,
                "NEOS" => NEOS,
                "JBS" => JBS,
                "VTC" => VTC,
                "VASH" => VASH,
                "CDN" => CDN,
                "SDC" => SDC,
                "SDCTEST" => SDCTEST,
                "EMC2" => EMC2,
                "POSW" => POSW,
                "GCR" => GCR,
                "NVC" => NVC,
                "AC" => AC,
                "EDRC" => EDRC,
                "SYS" => SYS,
                "SLR" => SLR,
                "SMLY" => SMLY,
                "ETH" => ETH,
                "PSB" => PSB,
                "SLM" => SLM,
                "SLMTEST" => SLMTEST,
                "XBC" => XBC,
                "IOP" => IOP,
                "INSN" => INSN,
                "OK" => OK,
                "BRIT" => BRIT,
                "CMP" => CMP,
                "BELA" => BELA,
                "FJC" => FJC,
                "XVG" => XVG,
                "CLUB" => CLUB,
                "POT" => POT,
                "GRC" => GRC,
                "AUR" => AUR,
                "IXC" => IXC,
                "NLG" => NLG,
                "BTA" => BTA,
                "XMY" => XMY,
                "BSD" => BSD,
                "UNO" => UNO,
                "GAME" => GAME,
                "STRAT" => STRAT,
                "STRATTEST" => STRATTEST,
                "NRO" => NRO,
                "USC" => USC,
                "THC" => THC,
                "LINX" => LINX,
                "ECN" => ECN,
                "DNR" => DNR,
                "PINK" => PINK,
                "ATOM" => ATOM,
                "PIVX" => PIVX,
                "PIVXTEST" => PIVXTEST,
                "FLASH" => FLASH,
                "ZEN" => ZEN,
                "PUT" => PUT,
                "VC" => VC,
                "NAV" => NAV,
                "ZEC" => ZEC,
                "ZECTEST" => ZECTEST,
                "RBTC" => RBTC,
                "RBTCTEST" => RBTCTEST,
                "LBC" => LBC,
                "KMD" => KMD,
                "BCH" => BCH,
                "NEBL" => NEBL,
                "ZCL" => ZCL,
                "ERC" => ERC,
                "DMD" => DMD,
                "BTG" => BTG,
                "TOA" => TOA,
                "BTX" => BTX,
                "VIVO" => VIVO,
                "FRST" => FRST,
                "HNC" => HNC,
                "ONX" => ONX,
                "RVN" => RVN,
                "GBX" => GBX,
                "BTCZ" => BTCZ,
                "NYC" => NYC,
                "WC" => WC,
                "MNX" => MNX,
                "CRAVE" => CRAVE,
                "EXCL" => EXCL,
                "LYNX" => LYNX,
                "LCC" => LCC,
                "TRX" => TRX,
                "KOBO" => KOBO,
                "HUSH" => HUSH,
                "OMNI" => OMNI,
                "OMNITEST" => OMNITEST,
                "MONK" => MONK,
                "MEC" => MEC,
                "BTDX" => BTDX,
                "XAX" => XAX,
                "ANON" => ANON,
                "LTZ" => LTZ,
                "XUEZ" => XUEZ,
                "BSV" => BSV,
                "BST" => BST,
                "BOLI" => BOLI,
                "ONION" => ONION,
                "RPD" => RPD,
                "FIX" => FIX,
                "FIXTEST" => FIXTEST,
                "AYA" => AYA,
                "CPU" => CPU,
                "NIX" => NIX,
                "SUGAR" => SUGAR,
                "SUGARTEST" => SUGARTEST,
                "AGM" => AGM,
                "PHR" => PHR,
                "THT" => THT,
                "PRJ" => PRJ,
                "SCRIBE" => SCRIBE,
                "XDC" => XDC,
                "LKR" => LKR,
                "XWC" => XWC,
                "SLS" => SLS,
                "BEET" => BEET,
                "TWINS" => TWINS,
                "TWINSTEST" => TWINSTEST,
                "DFC" => DFC,
                "QTUM" => QTUM,
                "QTUMTEST" => QTUMTEST,
                "CRP" => CRP,
                "ELA" => ELA,
                "BND" => BND,
                "BNDTEST" => BNDTEST,
                "AXE" => AXE,
                "NRG" => NRG,
                "SAFE" => SAFE,
                "STASH" => STASH,
                _ => INVALID
            };
        }

        internal static IEnumerable<CryptoCurrency> GetAll()
        {
            yield return BTC;
            yield return BTCTEST;
            yield return LTC;
            yield return LTCTEST;
            yield return DOGE;
            yield return DOGETEST;
            yield return RDD;
            yield return DASH;
            yield return DASHTEST;
            yield return PPC;
            yield return NMC;
            yield return FTC;
            yield return BLK;
            yield return NSR;
            yield return NBT;
            yield return MZC;
            yield return VIA;
            yield return VIATEST;
            yield return RBY;
            yield return GRS;
            yield return GRSTEST;
            yield return DGC;
            yield return CCN;
            yield return DGB;
            yield return MONA;
            yield return CLAM;
            yield return NEOS;
            yield return JBS;
            yield return VTC;
            yield return VASH;
            yield return CDN;
            yield return SDC;
            yield return SDCTEST;
            yield return EMC2;
            yield return POSW;
            yield return GCR;
            yield return NVC;
            yield return AC;
            yield return EDRC;
            yield return SYS;
            yield return SLR;
            yield return SMLY;
            yield return ETH;
            yield return PSB;
            yield return SLM;
            yield return SLMTEST;
            yield return XBC;
            yield return IOP;
            yield return INSN;
            yield return OK;
            yield return BRIT;
            yield return CMP;
            yield return BELA;
            yield return FJC;
            yield return XVG;
            yield return CLUB;
            yield return POT;
            yield return GRC;
            yield return AUR;
            yield return IXC;
            yield return NLG;
            yield return BTA;
            yield return XMY;
            yield return BSD;
            yield return UNO;
            yield return GAME;
            yield return STRAT;
            yield return STRATTEST;
            yield return NRO;
            yield return USC;
            yield return THC;
            yield return LINX;
            yield return ECN;
            yield return DNR;
            yield return PINK;
            yield return ATOM;
            yield return PIVX;
            yield return PIVXTEST;
            yield return FLASH;
            yield return ZEN;
            yield return PUT;
            yield return VC;
            yield return NAV;
            yield return ZEC;
            yield return ZECTEST;
            yield return RBTC;
            yield return RBTCTEST;
            yield return LBC;
            yield return KMD;
            yield return BCH;
            yield return NEBL;
            yield return ZCL;
            yield return ERC;
            yield return DMD;
            yield return BTG;
            yield return TOA;
            yield return BTX;
            yield return VIVO;
            yield return FRST;
            yield return HNC;
            yield return ONX;
            yield return RVN;
            yield return GBX;
            yield return BTCZ;
            yield return NYC;
            yield return WC;
            yield return MNX;
            yield return CRAVE;
            yield return EXCL;
            yield return LYNX;
            yield return LCC;
            yield return TRX;
            yield return KOBO;
            yield return HUSH;
            yield return OMNI;
            yield return OMNITEST;
            yield return MONK;
            yield return MEC;
            yield return BTDX;
            yield return XAX;
            yield return ANON;
            yield return LTZ;
            yield return XUEZ;
            yield return BSV;
            yield return BST;
            yield return BOLI;
            yield return ONION;
            yield return RPD;
            yield return FIX;
            yield return FIXTEST;
            yield return AYA;
            yield return CPU;
            yield return NIX;
            yield return SUGAR;
            yield return SUGARTEST;
            yield return AGM;
            yield return PHR;
            yield return THT;
            yield return PRJ;
            yield return SCRIBE;
            yield return XDC;
            yield return LKR;
            yield return XWC;
            yield return SLS;
            yield return BEET;
            yield return TWINS;
            yield return TWINSTEST;
            yield return DFC;
            yield return QTUM;
            yield return QTUMTEST;
            yield return CRP;
            yield return ELA;
            yield return BND;
            yield return BNDTEST;
            yield return AXE;
            yield return NRG;
            yield return SAFE;
            yield return STASH;
        }

        internal static IEnumerable<CryptoCurrency> GetMainNets()
        {
            yield return BTC;
            yield return LTC;
            yield return DOGE;
            yield return RDD;
            yield return DASH;
            yield return PPC;
            yield return NMC;
            yield return FTC;
            yield return BLK;
            yield return NSR;
            yield return NBT;
            yield return MZC;
            yield return VIA;
            yield return RBY;
            yield return GRS;
            yield return DGC;
            yield return CCN;
            yield return DGB;
            yield return MONA;
            yield return CLAM;
            yield return NEOS;
            yield return JBS;
            yield return VTC;
            yield return VASH;
            yield return CDN;
            yield return SDC;
            yield return EMC2;
            yield return POSW;
            yield return GCR;
            yield return NVC;
            yield return AC;
            yield return EDRC;
            yield return SYS;
            yield return SLR;
            yield return SMLY;
            yield return ETH;
            yield return PSB;
            yield return SLM;
            yield return XBC;
            yield return IOP;
            yield return INSN;
            yield return OK;
            yield return BRIT;
            yield return CMP;
            yield return BELA;
            yield return FJC;
            yield return XVG;
            yield return CLUB;
            yield return POT;
            yield return GRC;
            yield return AUR;
            yield return IXC;
            yield return NLG;
            yield return BTA;
            yield return XMY;
            yield return BSD;
            yield return UNO;
            yield return GAME;
            yield return STRAT;
            yield return NRO;
            yield return USC;
            yield return THC;
            yield return LINX;
            yield return ECN;
            yield return DNR;
            yield return PINK;
            yield return ATOM;
            yield return PIVX;
            yield return FLASH;
            yield return ZEN;
            yield return PUT;
            yield return VC;
            yield return NAV;
            yield return ZEC;
            yield return RBTC;
            yield return LBC;
            yield return KMD;
            yield return BCH;
            yield return NEBL;
            yield return ZCL;
            yield return ERC;
            yield return DMD;
            yield return BTG;
            yield return TOA;
            yield return BTX;
            yield return VIVO;
            yield return FRST;
            yield return HNC;
            yield return ONX;
            yield return RVN;
            yield return GBX;
            yield return BTCZ;
            yield return NYC;
            yield return WC;
            yield return MNX;
            yield return CRAVE;
            yield return EXCL;
            yield return LYNX;
            yield return LCC;
            yield return TRX;
            yield return KOBO;
            yield return HUSH;
            yield return OMNI;
            yield return MONK;
            yield return MEC;
            yield return BTDX;
            yield return XAX;
            yield return ANON;
            yield return LTZ;
            yield return XUEZ;
            yield return BSV;
            yield return BST;
            yield return BOLI;
            yield return ONION;
            yield return RPD;
            yield return FIX;
            yield return AYA;
            yield return CPU;
            yield return NIX;
            yield return SUGAR;
            yield return AGM;
            yield return PHR;
            yield return THT;
            yield return PRJ;
            yield return SCRIBE;
            yield return XDC;
            yield return LKR;
            yield return XWC;
            yield return SLS;
            yield return BEET;
            yield return TWINS;
            yield return DFC;
            yield return QTUM;
            yield return CRP;
            yield return ELA;
            yield return BND;
            yield return AXE;
            yield return NRG;
            yield return SAFE;
            yield return STASH;
        }

        internal static IEnumerable<CryptoCurrency> GetTestNets()
        {
            yield return BTCTEST;
            yield return LTCTEST;
            yield return DOGETEST;
            yield return DASHTEST;
            yield return VIATEST;
            yield return GRSTEST;
            yield return SDCTEST;
            yield return SLMTEST;
            yield return STRATTEST;
            yield return PIVXTEST;
            yield return ZECTEST;
            yield return RBTCTEST;
            yield return OMNITEST;
            yield return FIXTEST;
            yield return SUGARTEST;
            yield return TWINSTEST;
            yield return QTUMTEST;
            yield return BNDTEST;
        }
    }
}