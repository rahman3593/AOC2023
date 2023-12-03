using System.Text;
using System.Text.RegularExpressions;

namespace AOC2023;

public static class Day1Part2
{
    #region Calculation

    private static string[] _input =
    {
        "51591twosix4dhsxvgghxq",
        "425nine",
        "llvmhjtr8nbbhrfone",
        "lpbjvpbtdfvtxtdvkpjs7qrvddkzmjtlqtg",
        "3sixnineseven",
        "rfmsqbkms7three",
        "33291six",
        "oneonevstpxxrjpnine7six",
        "75sevennine14mzqljsjfbb7two",
        "three6two9jckvk",
        "zprj8394threehczfkncntk",
        "mkqtlrzmzfsix2ccqsnnxtwo4sevenxp9",
        "tdszrfzspthree2ttzseven5seven",
        "two3fiveckrsjr",
        "four14three7",
        "4fdkcclmxmxsevenfiver",
        "5sjnnfivefourzxxfpfivenine7five",
        "77sixfive",
        "twofivecrkvmpcpvzddvzcmjhjlthree8fcrrninefive",
        "fivetwo562five",
        "2ninekvdbfnmjmd6ninentpktmgseven92",
        "2twonine",
        "5fivesprm4ndqzbqnjqx",
        "7jfq9",
        "1hgnkmx91",
        "2jcrmhfvntc3lqnine4five4",
        "zvqmpjrpninejhqrnineggghcrjfd3onefive",
        "11three64qjjhqdnonetwo",
        "rmvzjnbonetwo6",
        "eightfive698threenine9",
        "8eighttrfngsklrkfivefourninefourqhclfcp",
        "1z",
        "fivegfslvcvtvs4",
        "sfq1twosevendbjq2nine4rzmdpmgcx",
        "seven816one8jmcqqhfnthree",
        "twor4325rsl5",
        "four2vqhninexqqhlfhfouronejks1",
        "7hjmmxhdnine8",
        "1eight3hqgshtb147",
        "four6sixeightone",
        "twomvkjxbqxzhnnmjxstkgfhzzdsc1fivefivesix",
        "3slhhsfnkhhlxtvqfrhvdzzkvlzcnlxgd4ninechp",
        "meightseven8onegghfsfeight84",
        "kmxckzqdfeightsqfivefivetfg77",
        "dc8",
        "mktwonecvqsxhqrjfninethreethreedkllgfxrxrffzvdbqdj2c3",
        "8shsxjmqmb3kpvj485nd",
        "rbdlrxsmjvnkttnpfour6twoseven",
        "bkt1seven",
        "threehkjhm9",
        "threeeight8sevennine7nlx",
        "jmvj4ctqpccsixseven",
        "4fourmtwoxcsvlvlhctdpxns",
        "eight7three4729eightbslrgrhs",
        "26seven1",
        "7ffseven",
        "9rsgmlgcsevenxkmsd17three",
        "snzn6htcqxqj7bf",
        "ppr7six73znmtmgrzrp9",
        "61mj7dvddfseveneight",
        "threevfive3fourseven3",
        "xznsxcxsbggvctqqb82two",
        "five4none",
        "foursevenrl12threegpbvdsspkrfour",
        "9sevensixthreerftbxgthree",
        "6fph",
        "996three",
        "64pkndfphqrglbgcpseven",
        "72749twoeightcpqfzqcrns",
        "xnzzhvssixtrlfftrjr5two9threenine",
        "four8hzkkrpb71glpqsnkvcb",
        "sixsix1",
        "9lfdtwo4sevenjhv911",
        "chxjljdh8jztwo61three",
        "twothree11",
        "hft2dmntjgzg1",
        "rtfckbnqxfdldgttbltdr33kqhxhkeight4",
        "ninefourseven4nine5",
        "25fsmkbsevenpzhgdhnxnbsix3",
        "bd1frglljngg8one1",
        "34six",
        "96cpcmztffqdrfrfslfour4lpnbmrfm",
        "psxrlseven2zmkvrhckqcxdl91",
        "ninexkfjcjkjb8three4xeighttqsrgbmfdt",
        "2threesixeight1",
        "ggxzf3gkdvsqxggltxdhdbhm5",
        "sixtwo89six",
        "eightnine3",
        "threemdrhqpone6",
        "sncpmhtwozsfpcpxgq9three",
        "rtwone37three7xhzlckfclbltdkrgqbcrhpqzg",
        "68sixbgsz35",
        "kdeightwo69",
        "four7bfq3four",
        "sixone3fivedgmrrvjqrr7three7seven",
        "sixthree6",
        "onethree3onevdtlkrfour4",
        "eight4seven5cszgblfseven",
        "two8ddmjtg",
        "fivejnvrdmghnvrmrjeightnnxpv8",
        "2threezvklqkpml",
        "two76cdfrmfckbjc",
        "zqxpg42sixeightfour76",
        "3eightvqpxzsn2bnbkrfb49",
        "eight85five",
        "sixngs8xjseight4",
        "296pfsgnlpbmngzlrrldznmrj1mjgvtxkr",
        "six4bvrdgxh",
        "34eight56eightsixhphnbgscfb",
        "two4twosixthreeggfdzlbkxxqmtxtczdfj",
        "four4tqrjxxcrztwoeight",
        "one73zpfhjvjh2",
        "7eight35phcfcdzhhpzn49eight",
        "zqcmlcqfneightsixrpmmhcrssk6dclcpmhzqhrbcnkxjdfjvrf",
        "1threegkhpq7nfrksvm69nxpvgvthfzoneighttc",
        "gtjsevensixsixb9",
        "nine73nine",
        "cbhsddcmzmdv2bnnffour",
        "85hhqkqmv",
        "six2jfxfgpg9",
        "fiveeightskrn1",
        "khvcf3five8qj5",
        "sevenfive7ptb",
        "tscc9psz3gtnsnksn",
        "xzlh7zfivefivejgr",
        "one4nine8three3",
        "2kjkbbvftktkvpbp8gkcnrrkr6r",
        "565three718five",
        "twojjgcfz3fiveoneftvnldxdhr2",
        "13three",
        "phbvxsnnineksttklfljm85",
        "tvzpbgzhmbnine1eightbpjtkflllg",
        "7five3",
        "2623four",
        "nvfchhrbcone1nine",
        "mjv5vtmlmsfcfmt65five1",
        "7one2",
        "4six4",
        "dlbzctlxpjxxqk96pmdgdfblbfjnsxjmkoneqgeight",
        "seven4nzvxldvzvjpzlzxb4eightnine6",
        "2vzblzhrxnc8qtgvxxzgkeightblqfftjtnxrbpvlsgvd",
        "thfdzxfqcthqfcnrt2",
        "qxfpbbnfczfourh4twodjrhp",
        "4m2fivelklgfgr6three",
        "4tsbs74",
        "one6twomzfncms2lrgzgsspkjmcgqxp",
        "six5fourgzrhbvdnzzllh",
        "9seventwothree8sevenfive4two",
        "7eightdprzmjvsevenfourfiveeight",
        "twosjzhsb29lqzkjbtshp5",
        "8four6two",
        "bklkfctjb84one",
        "sevensevenfive7seven6",
        "vklhzsjz5fiveeight5",
        "fourmlthreecjspnchzrthree8tb",
        "7gsfvptnpcl2n82",
        "58mdllbtjkkzcmdgzbeightbzqmfour",
        "2vtlzkzlsfive92vbpnq",
        "jbcgqvr28ksbphtfourfourfksnxjhtb",
        "21ljfcmgtmdqfive",
        "threejhhstcxfive64sixeightthree",
        "7tqpqngnrmnnxt3pjbcqjmktvj",
        "fmqqc9twoone15four",
        "5six13dnkxtqrxrh",
        "8xxpnpfivethreeh5ktnpctlqrgtl",
        "9hgmlnzsbmbsbjbg9",
        "8mnlsqkpqp18jkftxzfcklsgkvjr4threergdbrrzbb",
        "eightglhhjsfl819lkzlxjvcshdtjhxvjs8",
        "gshmsmzfbcrhvnfnpppmmfmngcv2snrponeqgxvtx",
        "9sprkdkk3cpjzlzphfdbhczbpssix",
        "nine8954five",
        "oneonettsixckhgprszjckhx2",
        "seveneightgnhzhm9pkthree3three",
        "5mjkpk",
        "sevenfour832five",
        "fivellhglxm2twoneq",
        "fqtfqdgeight2lfklmhrnfive",
        "flqdfkmlfthdvzncvbfour7gq",
        "793",
        "fourninetwojrfp4three5three5",
        "snnnjlhcnine84eightjthbkgtslhp4skglpzhz",
        "mnxfgpg862ninefive26",
        "bmdtbfjonegprzlxqlkb4mcscbqnv",
        "nine9fourfourfive1fivethree2",
        "eightfqrqz8",
        "fourpkd1bpxczlzthreecptvjlgzfmtqnr",
        "25onejrksrlccgrqtkcsmzccnine",
        "5nine26three88",
        "25four299fourfour",
        "hlrbll8vnhjlfjrkd",
        "ffourthreefourkgjbsnbc6",
        "eight8mpqpsgxthreegmxrhqkqbhgstcz",
        "three82five1",
        "4dxvzg29fourdsh",
        "ffgdlggchpcq7four34lfive",
        "seveneight9eightnpjmh9eightfive",
        "bnjrnsdfjg6",
        "76five",
        "five4nine6six",
        "q339eightkhnjsixttvqzlbchleight",
        "koneightonenine2nftlzxnkbctmjvzk98",
        "511",
        "4cghqsix3bqr",
        "958three",
        "seven2vmrkjqgrlb5",
        "9three6one5jdrnlfour6nine",
        "four2xdrqqsktone",
        "1sevendxkhzglzxgcmonesixrplhlplhnone",
        "6threefourhshvnszlqrzb",
        "7hctfsqf2jzjkxbljg",
        "sevencxncnc68",
        "49lfdkv2zbhddmbfive",
        "sevenfdsmsmmgzv29two6rpxsgpdsjxljcthree",
        "hgfqhdfb4mninesevenzngfljcvpvvkmghqxoneseven",
        "gtlqcggrp6lzjfive3rtrqvszcrsevennine",
        "qvhztzsfddxbbxsr88",
        "nine5kfnninelknrbf5bjrrthv",
        "pfnmdzksjcjcbvlvgcbheight47",
        "sixfour8",
        "cdbxkcqseven1",
        "onefive65mdbrnlg",
        "vlcxxcxhfkjhm6two5",
        "bfpnhlzq3tgcmhd4",
        "6three69eightgmxsseven",
        "three1six",
        "fourgqqgvltwofkxzmcfdmz4",
        "24four68nxs84spjnpfsdv",
        "m1threesvlhmgsbn",
        "three7jcvclg84sixfjvvtkfk7",
        "hznlsixjqnlvpmninejrvfpplbm5",
        "mgfrn6",
        "xb9469",
        "48713fivefour6",
        "sevenfiverzlhdzr59lbtvltccgbstzxksb",
        "rxkppsh771",
        "dldhcgdvtwosix3",
        "one4phkrftwo",
        "rrdrpfddtphv88jldqht",
        "vgcpcmrj6",
        "9zdqnzlthreelxzmlhsgdc1pddz",
        "669onesix",
        "5eighthlbhzlpms7qvbftcrone",
        "8mttfjqjnsf528hzvljcx",
        "eight9tseven25csfeight1",
        "7threethreetcdxnhnnftwosevennine",
        "54tsrjthq831sixcmxzqg",
        "61eight9kb5",
        "qlxmg4zhcpfxvrhlgjlcbxvxsix",
        "95two",
        "four75eight",
        "6fbrnsflmxstwo",
        "25",
        "eightcdl979gxzv97eightwogdv",
        "eightgbx85sevenseven",
        "3rfvzeightsjcctzxvtcrsix",
        "fivevqgm14",
        "dbfkfnfbckncvseven83drnkzt1",
        "11ninesevenxlxfr",
        "4ptvstqt7fivebznine",
        "5qmcnfour9",
        "four5mndpqsmxninethree56ctnlcpbtzmthree",
        "four2bqnbcbninemccbzhrfourbgrccrsznskjn",
        "rjdfqd24seveneightwom",
        "9ztmbftvvzlqlr4",
        "qprftkd3vkfhtwofour33five",
        "fourdtmjbtvvdxdhj5",
        "jpttch9",
        "9jkngffbxhg",
        "one79twoonesix",
        "2eight528nine2",
        "psncczvbeight3",
        "4seven7nlgrlzsqjsdb51",
        "five98lqc8",
        "nine377rcgvvhdghrg5scmff1",
        "8fvcxpr6kx5cpcrjdpnjcsj",
        "ltlbphmcc7six2",
        "4threek",
        "8hzmfhrnvt",
        "tbmzgpgkkxc89z4sqpd",
        "fivefourdjpdgfournine37eightzqbpgcnfrq",
        "sqh6llxn9z",
        "five1sixrqqclkhx334sixone",
        "289",
        "nqcspsixone822five",
        "bq19",
        "mxdqptgg99982vpthreesgdgsf",
        "vp334fourhdtjvlgtwo9seven",
        "3five157sixgzgxxfive2",
        "dvmtwone3sixfivetwo6ninezpjv",
        "9trtrdkldqj429hsrtd8",
        "6three3sxsbbhpgsix1",
        "3gccsixcghh",
        "six4nnbg",
        "ppvljnh5",
        "sevenmghppptnrtrzh7",
        "4sevenszkgbpldhklrtclm",
        "9qjsxmrmdm",
        "twoskbhlqhnkmgzkpvtft9five2qrkeight",
        "1v",
        "988fkxgkbonerglfsknxr5eight6",
        "xkdklvjbhv977lvlnmrj3gnfjrnttm",
        "1fourthreesevensevenxfdmtdone",
        "fourmg4xtvjbfmqkhtbslq1onehmtrtvsslrjdfncr",
        "twosgdlxsixfive1",
        "bscpkcfp8mhpvzn7threefqgcpfpmftsrmktwo",
        "sixeight4vthcxd48two",
        "1ninehclngfzbktvpjone",
        "one2sixmzxdqxvg4oneoneztbmplctc",
        "5tkhrmfrvonetwo",
        "lfgveightnqdmrv9six",
        "zzgmcr1jgzjjljhqmtnbrnbt",
        "one3vfour7eight",
        "fourseven3ninenine5four",
        "92kpdtggsb",
        "onecsfdhsn3gqmtfhc",
        "bhflvgdfkhprqqdgs6one",
        "1five93pmrhdvmgp7onesix",
        "56mgkt",
        "rksixfourfourthreefive3fdrbtgmdt2",
        "8one7",
        "rgvccbsrphxkmdgjkrjjztdzzmkgqbcdkseven69",
        "three4eightsixjgbnthfxvltwosevenxjkd",
        "5cffmxhdbtgtlffdb",
        "8fivetwoneb",
        "5trtgsgkvplfvqccknine",
        "two4gjjmptwo",
        "two845lltssr6",
        "six8xngnhbctl",
        "nhbxglqfjrhmhneightqmvlnqtwo53",
        "7nsr",
        "one2seven",
        "8eight2jphsz9",
        "9fivebv7kmxqtdvxq",
        "ninec4four",
        "vrtczjzbzg8bgf",
        "pvhnfhvsixbppv4oneshhqp8jprm",
        "tnxqmfive1khnmb",
        "onefivechd69nine8",
        "sxeightwoeightkpjxbkrvtbllbxfshseven4threemkbx7",
        "twofgcfp7ddjqvhrbvmkjdsltfps9bttz6",
        "sixninezpsbrvhvlz4",
        "four6sbtdldjcjrn7",
        "79drd742",
        "mmccvnldbhxcfnpxrftqc1sixlncsqs",
        "jjdpbsm2",
        "9fnhthreefourtftrmqhkmxrpnnhbxvk",
        "five168sixs4",
        "65fourkpzbhhgsghxvhlvlftfmck62",
        "8fivesixsvmzjhdmdqsixntzrckdk",
        "gfzjxptdqnineonepqqsldlvjrg5pdgthrslpfcfive",
        "38mmkcseven2four",
        "vghjzfchxsqq8fivefourone1",
        "tttjzcm3",
        "jpn764tsmrfvtjp7four",
        "onelhbhkmf7",
        "5ssfzvfrrvgleight71",
        "52lkxkxdjch5",
        "3eighttffhffht4",
        "832",
        "2gbhzrgchz",
        "threessdmstrhchfq73ftcfbrtrvf",
        "8xqs9scc",
        "xglmdxq24two28kcckrsqpzone",
        "16mkcl",
        "ldhmz3",
        "xzvttst5",
        "drkkc3",
        "8zhbplhvcr4",
        "one1xzbrkd59",
        "xzzbsnktjhjltsfrrrz3four",
        "8vlfgxgzsnfljbnnmlpz5nine3three",
        "99onehzdqm",
        "5zdtrvccn",
        "75sixsixkxldjnxslnvggnvvjbzcrqveight",
        "9sixztkk",
        "three9sevenone",
        "zxsgxfxpkpp45",
        "9hkshgthreekkvrplztccvb",
        "sixbvdxrhrc16",
        "1jbjbqhnqgg5shmgfm9seven99fvpnrrpks",
        "sixstsxgbmcx12qhhdr",
        "9trfxqzkdstwo2dzone5three",
        "one3drbrbtsevenonekmfdlffive",
        "nsnchfkxttwo2zgpbvkvktwofour",
        "cnzgzdvfm9",
        "8fst5jsgmxhbgklninebkkrs577",
        "xskvpkzcx2twoninebslrbdmqseven",
        "qlbpjqmptkseven9lqmcdvjcxqsix4",
        "eight7six2",
        "33h8rxmtlctrz67dz",
        "3rmkrn83seven4bxthree",
        "mmznine55",
        "1onefour",
        "two4fivenine",
        "fivesevenpp2onexcxjvllseight",
        "onehtfzdtjxskmzsbc4sixfourz",
        "mfkttfxqvtdqdrl93",
        "567",
        "qqpnrfninetwo55eight",
        "4qqmlrfbfrvpxvphjpbc",
        "nltblqfourbxxrrgvgkcbb5hzzgfour5dmdxl",
        "three2526ngfzssixsixseven",
        "1tffj2fcddnfxrzx34",
        "59jd",
        "sevenr8sevenvxltmxcssttwo9",
        "svklhbtwoxbbmk6ninekptrln7sixjqbjgxdhzr",
        "krbmcxpnxfrn4",
        "pnkfournjgpggxzjd97two",
        "cplfrzbgbleight2z7six",
        "ninep8xxxnine",
        "xqlrnzlz92ninehblgkztwonerc",
        "1nine7",
        "one8three361two98",
        "nine367qqslvgcxftwo",
        "3fournine3twofkcdmx6",
        "1b2ninethree",
        "6one4sevencnlsqzzmcxkxfnqjone9csmkx",
        "oneeightgh44eight66",
        "6x527threethreerggpfcfqlf",
        "eight1tnine7gjvtpvmqb1seven6",
        "six45six7fourmnhbskfthree4",
        "ltf4",
        "3hgqgdsmnsnine",
        "hjqneight5threeeight",
        "onekxbrlhkxgxbmbn6eightfourltspzkqdnone",
        "llfphldmghqrcnineeightonefive9vldfskjbhl1",
        "sixpjf5gjkdqkvvqhj",
        "2five685kvh17four",
        "pgslffcdvsix7oneightcs",
        "lznbhzonefivezgj45crzfl",
        "twosjggnvbxcmtwo8four5",
        "fourhtstxbkcz6fclrvgfrgbv",
        "nine4ninefourfdkdmjvlvzgsnjsfseven",
        "three318lmzcfive57",
        "5pmcnc",
        "861",
        "qbbhpjsg5r2",
        "jtxcphmrjnscfhqhk6seven2threefive",
        "qd1sixninefour",
        "four7fivethree65",
        "7dlzrddgrgfour3hxsttlnkbm29",
        "four4twonine8",
        "5zblkgmxninesevenbrhntxm",
        "xfvl9589",
        "five2seventhree6gbzb2",
        "cvmqqtskxlthree1",
        "sevenseventwo9xthreevzfdmfqvdf6",
        "six72sixeightnine9",
        "xrjnqqtlxz8bbgsqrseven6two9",
        "29seven153eightzl7",
        "sevengntsfmzkfb8",
        "1fiveseveneightdbvbtszptqlnineseventhree",
        "four6rks1v",
        "52eightninez",
        "5jspztgxrpt",
        "bq8jpttmm2",
        "fourctnlpkbrsfive9qd",
        "85twothreebbpsjcfh12oneeightwov",
        "xhxgfrcljq7six",
        "zh9",
        "9sixfiveseveneight",
        "rgqzbrldqrhtzjbsbzggktnc4nine8one1",
        "xcmfbrprxr72qqtnine",
        "tjphvghjfthree1one",
        "twosixeight9fourone",
        "eight48xronebc",
        "t6two34nkmfgmsnnvlbq3",
        "eighteightkx86",
        "82b6fcvvxpsx84",
        "threeeight66two",
        "six4pkbhtxlteighteightsix",
        "three7snrrdfb8sixninetwo4mltj",
        "5jqbgnqthreemjzgbvpdeighteight8tvf",
        "nine6zrbpsfrfqnsixlkmxrkxln",
        "2fivedvkt2998",
        "j2eightzqspbs",
        "mmp694eighteight",
        "3chzvrsrhzrcrtwoone2",
        "qqqzxcqmbb8nine",
        "sixsone7onesix1vvrqszvmnrh",
        "8threegtfnmkgthreesixthreeglhzqq",
        "threefiveone2three6seven4",
        "sixzkqbcg1",
        "two7seven85five",
        "cfhg3zmpfd644",
        "btsrthdbkt6242dhl",
        "hqlgnine5two",
        "2zgftzs8twovt",
        "mmpcgngmjjvbnsix35threezxjjxsqnlv",
        "lmmqsevenvjcvcqj55fiveninernmn9",
        "two7rgsbxnmddtjd",
        "36foursixsevencjffhxrsq",
        "4jxzfhxrphtgbjqfivefive",
        "99pqtnvtwo9crsbvsnrmtpltthree",
        "threedhk3hgvkp8nvbk6",
        "fivelkxdgvsq6twofive9hzjkdz",
        "ps7two9pqnnnvqpdbcpttjgrjl",
        "jjcfkvqdcl4twothreetwosix",
        "47one525",
        "23three2",
        "eight9four7gddxxfxcm9gdmmnfvbxr1",
        "745",
        "gkblgnrzsblklpb5bc8ftrnineoneseven",
        "jghbzdlmqbjm5glsqfffvzksc",
        "eightsix1five",
        "nznrzbdsv4",
        "16vdxm2hlrgtvgtdrbsix",
        "txk26eightnrjxrrlvffour2",
        "threesevenddmrsghzsjk2bdcqx",
        "eightthree9blrfjvrpfnjcfqrxcnine1",
        "two7three81htcdvdnxg",
        "seven1three6",
        "kplnzdjmkcrthreefour38",
        "bvf1sevenmcdfnv9lpnnh",
        "6eightqcznninesix",
        "two3sevensnpf6v",
        "eightthreeeight4986",
        "9seven7nine6nineseven6",
        "3two91",
        "six97three26hlxczxp",
        "65twopggttdksmtsblfpjbcphzc8eightwopx",
        "mbxtfmkfourrkspbkvbrnljsjhzpqsgtvrr2",
        "sixseven9one5",
        "three7twob98",
        "6c",
        "5797xjtwo83",
        "chrbcms6vpmrpctssbvqmvreight76",
        "mthgpstgchone6two",
        "597",
        "1799gjjdgzhg9eight",
        "vzqkgj27zpvxltzvrfcl47",
        "381lmxkxrfhbxqeight89tdhpbpqnx",
        "sevennine4",
        "29ninetwo1tvhpr6three",
        "dlbqfsdmdxhszmcpzshdthree3hvc2csbtfthree",
        "19khmsnhone",
        "twofourbtlsl1",
        "3sevenssevenfivefour",
        "8seventhreesevenseven",
        "three27rseven",
        "1jbdtfcdvvbzhgfsixrzqxkfktjmhkhfive5",
        "onetnznrrcthreefmmfivesbsvg4twothreetwoneqq",
        "sbjfxeight2tzbdkvqmmdd2",
        "vc4xfsjmt",
        "bfive9dmqgfnzvtngkbvthlrfjmsjtclbzbszfour",
        "31nbzfqvckd",
        "26kcdkzbjnpkpljxhgnhjgmtbrvkntjbqtwo",
        "3eightthree",
        "eighteight88",
        "five6bsix3rkchjzlfour94",
        "one9rrrbx3eightone",
        "6fourkxpdmt852eight",
        "8xhfbqqklnfive2one",
        "4ninetwoone6",
        "seven5seven",
        "1vzprkvk",
        "mczkrcdx7rzvgdd6ktcnktpfkpp",
        "sixnine988one",
        "68shx",
        "jqfoneight4sevensevenhmcrqjlzhnl6vcsqgmgnnxqhvchx8",
        "1fourgqbjvjhzdppdq",
        "lcxjghp2",
        "sevenone8nlh5",
        "nine94krdvjv5seven3",
        "ninenineseven8threentgtlzfnrfbhxxzn8jt",
        "nine37",
        "hbzztninexrrktrlktwohr1765",
        "5sixjdvfxdxslhthreethree",
        "2eighteight",
        "dfnbf65",
        "4onenineqjnlpninekgk",
        "oneoneeight974",
        "4nqqm83ninezkmbcblh",
        "7tpjhbeight1",
        "fiveninefdcnfourvdjcnsshnine3fivefive",
        "344",
        "crnqzpztstxvcgjdmkp6",
        "hgcvbscglp63tpfive",
        "seven5fivesixcbtblmlsixgvfbqttzonedld",
        "43threep",
        "zshzcplxth4nine2zcgsbzdlxtzbxggnine",
        "cqtwoneone9ckhnzmzfsevenfour8j3",
        "fiveshs8ttpcsznh",
        "hdpqds3seventwokbzlhxpj",
        "joneight9",
        "hmxxnxhqfivefiveseventtgxqcxc3",
        "59sixoneonezjgbshzpfg",
        "1gqqz",
        "8two38fourjm7",
        "1fiveeight1four69",
        "88eightwoffg",
        "threenine3threegqvtvtxgninerdprd",
        "7sixthreesixsixmgzlqlbsslseven7",
        "threegmrbgmsfourfourbvmhzpctkd5rzx98",
        "five193146mmqmf",
        "41fourxone",
        "2jhgqrkmmgbthreeeighttxg",
        "5xxbgpmm3",
        "5twonineffsevenfivetwonine",
        "seven98",
        "one7532rcc",
        "8djrctpqvpcd",
        "eightqqnhfnn2pjsevensixx7nine",
        "jkzjrbhsevenseven1",
        "4tnkqxkl69nrktzz",
        "six88five9nplcm",
        "xngrktpqclsmkqggj935oneeight",
        "8fourgbns",
        "eight47nine1two147",
        "vpshrqvfkjctpmhcfc22eightmqdxlsngbfn",
        "rfive1kxfbcpq",
        "twompnqfvqxqninevgvhqlpfqc15seven5eight",
        "9fournine4ntvhbkbhqn48mqhqhltbjpzrrgb",
        "ninesix2four937",
        "6cxpmgqnchk33mfdxfqdhxbfiveonethree",
        "9mqmldz3kjnsgfoureight",
        "4dmxtdvqvrvdrbfour5q",
        "8eightmcsbfive11four2thqxmbktdl",
        "zddeightwosixlmhrzfksevensevenfive3seven7four",
        "lvgfftzceightsevensevennineseven5twobkd",
        "nine7three",
        "zlmfvjfrxrrdmtxg965msd4",
        "two9five4sevennmrvdgzrf1bjdzbtrdlb1",
        "tjbnzrpzrflpfsrprsg9",
        "fourzcqfonesix279",
        "75fxlvc",
        "ldvmnfqpll7fourqxzpfctfxp1nhrhpvkbtmone",
        "seven4ninebpbdfjsxxmbqvtwo6one8",
        "fivefive47seven",
        "rxeightwomgzhcbnlmj72",
        "eight34xhbcmeightfour3",
        "nxszsbltqhthree4",
        "7threefiveninecqzfdjpdcg",
        "kdfour2",
        "ktworhdsfhhfqcrbzdslthmt2",
        "dpjbqmd7689",
        "threesix8",
        "61113threenine",
        "ninenine77fhtvsmfh23onefour",
        "bccdxg5three",
        "2eight1bnrx",
        "eight7sixdvvrqgt46874",
        "35onekpnthreeprznkpfvlneightwom",
        "52five6",
        "one3foursjnngjznqkfqklhjn",
        "eighttwomzrxzfqgtdthree3scbjdnq",
        "9fivecjgdnkxrt",
        "5nine442fb8",
        "nine6one",
        "241fouronenrlb6",
        "97sstjznxfcpccngfl7cxmzzcvptfive",
        "gvtsxbqzcone52",
        "5845836fourfgrvrchv",
        "7247zxfkqhvd",
        "fourxtwonine2eightfive",
        "znjxhfour229three",
        "fiveone8qjfmjbnnc",
        "1sqdjlfiveh",
        "fivegxfj9pfbxf5",
        "cnxmvmcrm4cfivedcnrnneightwosd",
        "four3oneone",
        "hbtfjlnplcsrxkt6rcqpfdseveneightwoh",
        "jqknine9xfour43sevenbgznxhh",
        "pvtztgjv47",
        "one9oneeight",
        "3npsq",
        "ninekmzdninejk7",
        "6threeninefhcpbb",
        "266",
        "pvtwocthreeeight1",
        "lpmshscqztgsgsb2zfcddqnvkseven",
        "dmoneighteight78oneeight9zqszseven",
        "eight8eight",
        "fcdlflbtfiverxfx9",
        "five7six5",
        "hhvmsspr4four8hhcjdhnthree",
        "three8qfzjpdztwodrkg5cg",
        "919lhzrx1",
        "foursevenfourfive6lvfour57",
        "crzmt7",
        "two71pzxnxtjkngfzm",
        "sixbmzlvcnine9",
        "hfbeightwo3eightfoursixfive",
        "j5twotwo57nine",
        "rmqq3sbjqnqmdjhmbp91hp",
        "3threezr",
        "fivesixfour81jqxx",
        "2bfeight7nine7",
        "fourfiveqjfkzsdxmgjmpmtone3hbgcvq",
        "7nrshoneninetwocpphnrfprz2five",
        "twoseven1bqjgdz2",
        "one7qonevmvb4sixhsbqgp",
        "fivethreethreegmdh1",
        "lv7d89",
        "2tbrnmflxfhhsixddn",
        "6sevennlhxsevensixt",
        "pd2kkfvtjbbgvfrcts",
        "djfoursevenflp2three6",
        "bppkvmxcrvffssdxgrr6mtlthree9six",
        "4szvlsixsevenxttwo",
        "ppggtqx8",
        "two3three6five",
        "threegplsmsjzjfcctwo6tkrkzmnk",
        "srtj2tsnxthreeonethreep",
        "szhnzblxslqthreejveightfvrrhbcqjqmmvczh1",
        "five2five25",
        "btvlzjhrxxdqdmbbcrmbffpmlmr9four",
        "1jdrpjpvkmmseven",
        "85bbbht",
        "2onel2p",
        "hdsfftwotpqcgdbdjbgnvfone3eight",
        "fourdgtccrxdnvfszgkjsj38",
        "twonine6twotvqxpskhonejsnpmtpctjfive6",
        "29eightcgskgdnmnhkpp63seventwo",
        "2seventwofhktwo9",
        "8kx",
        "32zxdzvfzjvtwofive9sevenfive",
        "2seven8pmdnnthreehnvltl7",
        "33sevenfournvnjp24",
        "two3m9kcsppfour",
        "hjfb9six5gtbppmzlfmfourtwodqzppcldd2",
        "4qlkz3",
        "4ninejzgpnkvq",
        "fbcpkspbcgrn6dmclmnqldeight",
        "sixtwodphp833",
        "sevenonesix5eightsrzpjzpj45rczn",
        "9fiveltfqjmkzbrm8oneightbq",
        "mxfqsrs5fpeightfive7mvclrlqhhkptpbqq",
        "438rktthreegvhltmsv",
        "dcl9xnntwosixthreesix7",
        "csxhsvkkkhfour4slkvjk1eight89",
        "three2eightfiveone",
        "17kqnstzmbthree9seventpld35",
        "ztxjhftwo1f",
        "ccfvc3three9five",
        "fmngmbkjppkxjnzqbqldmspbrrrhhrkrsix4",
        "9fivejthreepjtmtfive455",
        "4ncdvqfiveonefive5zxgjpptbnbsmbrfdpqrjnx",
        "ljctvztrxncpxsdtttwo2tnkkt",
        "five544mlzkztsblt17fivesix",
        "9five35bkbpjc",
        "6fourtwo",
        "nine5hqlbjp1onenvvnvsseven",
        "5qbvsbxtktqhgqxfgprsgsrrpdtpcmr8",
        "hhsgjxlz3gzxhz14fourtwofq",
        "6three8rmtrbnhvr",
        "9bhxvmhldnm6",
        "vkjjpkgdmxrzzfour7",
        "rhvrsrthsevenfour3eight5one73",
        "msqdzmfzfeight6qhrvzcdxfourrleight84",
        "pjtfflgfhqnpdk6three63five9six",
        "1sixcpcvbnnine9eightonenlnjfdfdmxcmcb",
        "zpgrbsevenmqskhgtrm6",
        "8hnqmmgrnsxhrxjjc2qjbbvpknh82",
        "5six7threepx",
        "bmlxvnqrxtqzkdlnnine5two9bpphfdhqj",
        "mtxrblghxrsbxhmgnbvgvffivenine49ztktxvfvseven",
        "tnqclrllq9fivebddnv",
        "56seven222pkmqk",
        "74eight9pfqghssgk",
        "nhmzdpbnlreightqgljp6",
        "nf3three2",
        "eight9glknfltsqsfdsixfour2tcfnzfmf",
        "four1ninetwo4sckcbgzrx663",
        "eightbcfsevennqznfmfivetwo7qgdjtwo",
        "64three",
        "8vgggxllsrhqjh2",
        "7jhthmpmlxlptgbnscxcthreeeighttwo3seven",
        "ktqlfveight1eightjnfxvvjk",
        "99qjcxgnpdvnbjqprbqnsjone3ninenmxkslmdsx",
        "9gn2",
        "qtlztwo7eight2",
        "nvzhsjsdp4sgrbmx36",
        "fldvmnlkq52nqtsccgfgtwolm7mmb",
        "tzvgkfx6ssnxfeightwov",
        "rrl8pxjj6onefour",
        "3hzhqbrdspfrn2eight8",
        "jcrcxtqh8three4",
        "ttwone449cxvvljcpzpqmngtzslnq",
        "3gnkgbjnsmxv2fourd8",
        "9zt",
        "kckeightsix8oneeightsix36",
        "vjcg4p",
        "jkzr3",
        "twofiveone1four9seven5cnhzm",
        "6one6",
        "s2twosixfvgrglfive2mtkrxznllj1",
        "cnhbzthlzllgghkxjgtrph45",
        "six5two",
        "nine5threefournine",
        "1rkbvrk8threevfkdbvxgj",
        "28six7dvone8",
        "74seven",
        "6threeseven92rvpg1",
        "hxvthvgk8vhn6kmljfnl",
        "fourztpprfkonemnjbsfdjlj8",
        "djnhxfxxl1five2threezgthn7",
        "vmhmlgljrpsix93sssixsevensix",
        "dqk8nrsrk",
        "jjtdjkfivegpfspqqjthreedkntgjslqreight7n8",
        "8four12",
        "8vlcfsixthreelvvdv",
        "zsjqvmghp6seventwo",
        "6tnjfl2cfzcbgqp5",
        "vgjxleightzqfklqdx4vlpvp2gqxdxpzk4",
        "12mshtkbgsndrdx7three",
        "htckznt2threeninej4fhmrtthreeeight",
        "four8hdbrmptjnine",
        "2xbk",
        "ljgcscxxjgdbpdpzfcchrqnmqqthree8",
        "three7six51",
        "four5five92ftqhjhx",
        "eightfthreebzbhk4tceight",
        "2fivethreefiveeight9fbk",
        "9four613two8cnpzgcrnmc3",
        "fqfive38",
        "nine88mkthree99lkvzgvpjk7",
        "784dxxcpszbzkdlsrgnnqfsixone7twonemvh",
        "onetwo5tzggnsix2",
        "xsclx3twojhslqrnc32pxfqsjxctnb4",
        "zrdbcccznzlfgz8jfpgllczxtnpmp58one",
        "four21one925rntdr",
        "38six",
        "seven3nfttdgkjhklmdqbkv8threefour",
        "75kblsbqhonevsx",
        "fourztseven8twothtwo",
        "gmktvrd44twonine4pnbrkhhzpl8five",
        "nineslj1six8two",
        "one98mxnkrbv",
        "9zmfour",
        "8dkfmthstlqvs9r",
        "cjmcjjjvmceight9rslcctdslsxthreexsjbffnine",
        "5eight677",
        "4twothree",
        "cvqbrkmgthree4tbmzrhqtpx",
        "24twoone",
        "nphprsbcfhcfrggktgzgvrninesixdnchjd2",
        "9sevennmxzpjbhct",
        "sbchgzqgdk8twosix667",
        "hkjlpqgtmglv3eighttwo7two",
        "gflktjvlfivetbgmbsxzdpdxjdgkzvn851sixfour",
        "five2ffivefiveonekldfpcfjg",
        "mlnvqltfsixnxqxsgfpxrpsxmmlnzsnineeight5",
        "six1z",
        "sevenpvhgctkcvgtjstwoeightzgqlcgq1gxzj",
        "fivenine13rbbxfs1zpvrstlkceight",
        "6zmcggdqbfptwofourfphdbdg99four",
        "one65ninetljqcfive8",
        "six57fourthree4fzctnjzcdm",
        "181one",
        "3one315gftsbtnggrq",
        "gcdvnzbvv55onemgcftkmzrxf",
        "697cnzql8eightvdsngsglkfour",
        "fourfiveqjptdn6",
        "pq83six7fprdbzvmgrhkzmjmxgnkcr",
        "nineeightfivesix8",
        "fiveseven931xhtnvrtr9three",
        "seven9ninetkhldts",
        "6threehlzfbppqmhrtxnfoursix2cxn9",
        "mphgdnggjt3flmdz14ninejjskfivenine",
        "boneight7one19179",
        "npdjlhskrdmvsvhtldsthree5tpt",
        "6rvpnvdqqpkkfvgclctqcmpdfvftt68",
        "91four3twoones",
        "seven793",
        "8h2four6cdsevencsjvcgdlrj",
        "4bzxqvp74mmdvjfdvq4fivec",
        "31tlvlrb75",
        "nndfct5ninesix",
        "ncqsnf6six",
        "fiveonefour8",
        "sixtwo6zjhvhkoneeighttbfv",
        "three5dcpmcsnmfhtwo5",
        "eightnqqkpnine4ninegb",
        "lgnsrbbtkgtwo7eightthree",
        "rlpcrnscknpjpqm2qqpllrzk8p9",
        "tvpqncpmffpmv9nineninesixnjbhbhgdlf2",
        "lzrhjdkfhn1",
        "jgjfckbrpvc3fouronefourfive3eight",
        "twozhkpzcdkjfour8eight",
        "5sevenfourtwo4",
        "1sevenfivehvppxvxvcnsnhdrflonefour",
        "4pshnstwo46fivetwoone",
        "three1onemdlc8pcqkzsrnhqone",
        "qvgfvfxnrp5bqdrlqd",
        "jzgcnslrfxxc72bqqqrzltqm18four",
        "nmjlnxktmvzzrgkbrffourdddbbt7eight",
        "3two9twothreerlztqftcgkznfour",
        "8fivefive5tkv",
        "4vtsnlclbb37eight2xprhpnddzj9",
        "8hbmfjxmqckxqrdjqxrnhg",
        "onef6",
        "8fivezcjtworgbxrfkjkbk5mdkdgfbnkkkljlv",
        "5six6prgqhbvcrr1msjcct",
        "mvzdrmdlrsdz9nqmbkb6286",
        "367",
        "94vjktbt",
        "twofivefour7three454",
        "2n",
        "six224",
        "z841dzxcthdx",
        "fourvnlj7twocchdcn976four",
        "threexmxq5five",
        "dscbqrjqmssnzbbdtx34",
        "8sevenhrvzqskpczsfhzrhrfch",
        "4qx",
        "6eightnine",
        "cnbxjrbsseven8hbdfmjvk6sevendrglnfq3six",
        "82threengstmq",
        "19f",
        "cvjrhrnxnfiveksrjgh8",
        "2six1dlpdds",
        "5xzhhnqpnsix8qthckdhggfdfour7",
        "9threetwoqznvtb4",
        "one8dseven",
        "3fivefourjzbk4seven8tvqgvh",
        "9kffjzvfxtwofive3seventhree5",
        "5onerxdcrrlgvfbrvrphnine5eight",
        "614pnrbdp",
        "eightfour1cvxjbztxgzznlpr8qbzkz35",
        "four5seventwo3",
        "9fourzzjfdqdkmxbeight41eightwopr",
        "eight6rfdhz793twonevkf",
        "vmrkgjgthreethree8ninesevend6hmjmkfdqz",
        "vqstkklpj4j8",
        "72jglrpp57nine7vcr",
        "sevenfbbgpxlvk7tmlvtjsixdtrnseven3d",
        "5jlb4",
        "jhkslf976fpseven",
        "jpfive1",
        "two2jpfztkeightssfsevennine56",
        "seven6rjchpgvmqgrxdddq",
        "four7eight",
        "zqoneight9mqmjtjcb",
        "ljcmvjf1ngrgzmttttqprks2kphjtgqvmeightvfmzqhdhgj",
        "77ninejjxxgbffive6zzgd",
        "4pthree5zp3one",
        "mhdzcmmsseven4three3bngxxqzclpkmcppxtwo",
        "bneightwo33ptmpcbfournine4five",
        "sevenfrzffbklg4dmdngxmsixnzjgpkngsfivetwo6",
        "six2onethreethree",
        "xhx4gvkbtcjbqvrhtwo6",
        "1mdfvninevchtrqthree",
        "onecrnninedjchhzkmzthree4qjnclshjlbn",
        "threeccgbz6sixlhnkcpfdzk119",
        "61dtwo",
        "ncsbdxnp43jlrxfhgzlrfzqjkzbkd",
        "nxfztwo9lhcc",
        "mds9vkninehzcdk",
        "twofive4jdcndg",
        "374",
        "threedrsh9eightcqkrslljl5tthree",
        "fourtwotwo8kl1bvplqfrc7",
        "threekldmmjkmc92sixsixonenine6",
        "bllccpcksq59zznr",
        "n35lxtnq3",
        "25hmzzxv",
        "38sevenkqgtfcpnj",
        "ntfceightmvhvnzjvv37bsj",
        "4sixfvrtgdsjvxsevenfouronefiveddns2",
        "eight29lnznht2oneonekgjkq",
        "4lthkrtj1onesevenninerfplsixfhxdvlhoneighth",
        "1seven8eightgxzvgmnqj",
        "7qfqvxcjttwoeighteightqqsgbsftseight",
        "slfqkljnine1oneeightlgskmlqgstwo",
        "sppqhlxqzkdtdqc6qtxsssdcf41",
        "tnggpjrnmrrgzpssptpk32",
        "6pcjglgdknjoneightssb",
        "ninefivefrglbccjmrchvbpsgxrq15fourfive",
        "7five1lmndzphnj4fouronesj",
        "jvhkb24htseven7",
        "7sevensjnrvxmsixthreesevengrh",
        "9h5xbdgpdjjkt1",
        "c14vbjvcv",
        "ninetwohfbm6fourjpgz676",
        "gqdtlzqvkplj48cxvtvjjlkmbstcfxd5hkbfdgtf",
        "ninelpxd8eightvmmbvgmhs3six1",
        "9mmlj4vvcxlnbsfoureight",
        "nzrjlxqhnffour1",
        "hl5fzsxdbvklx4five",
        "182ninedghflcgrqz4ns",
        "eightdmbqddsqmfive7qshcvdjx",
        "vdfzsevenoneone4ninemhclrkjspkxt",
        "2three1qzqhscbvmpnine86three",
        "1ninevvlzft",
        "1ghfnrvkn97sixqzgtm32",
        "sixnine4rsjghcsznfvs",
        "ph5mzknlknp5",
        "3eight3twotchnsqdtbkh",
        "63threerjlgv6three",
        "fivevvcmvrqfkdfshxjnfgsevensix3seven8",
        "21onebcsgvhtm6two",
        "bnjpqcqdzmeight2gtjhqeight",
        "1rsjbbhtkbbfourqzdhlone4eighttwo",
        "6jpnnlbstgjfjdrdgnthreepgh49hdxqghr",
        "five3oneonefrvnbnnlz",
        "gbseven9five6",
        "nine2hdltdjdp73phzrjnonegx",
        "3two3eightjszbfourkxbh5twonepr",
        "5cfprzgxtf3465five",
    };


    public static int Calculation()
    {
        return _input.Select(Replace).Select(y => y.Where(char.IsNumber).ToArray())
            .Select(x => x.First().ToString() + x.Last()).Sum(Convert.ToInt32);
    }

    private static string Replace(string content)
    {
        var replacedString = content
            .Replace("one", "o1ne").Replace("two", "t2wo")
            .Replace("three", "t3hree").Replace("four", "f4our")
            .Replace("five", "f5ive").Replace("six", "s6ix")
            .Replace("seven", "s7even").Replace("eight", "e8ight")
            .Replace("nine", "n9ine");
        return replacedString;
    }

    #endregion
}