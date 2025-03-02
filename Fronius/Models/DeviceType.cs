﻿namespace De.Hochstaetter.Fronius.Models;

[SuppressMessage("ReSharper", "StringLiteralTypo")]
public enum DeviceType
{
    [EnumParse(ParseAs = "inverter")] Inverter,
    [EnumParse(ParseAs = "powermeter")] PowerMeter,
    [EnumParse(IsDefault = true)] Unknown,
}

public static partial class Extensions
{
    public static string ToDeviceString(this int deviceType)
    {
        return deviceType switch
        {
            -1 => Resources.NA,
            1 => "Fronius Gen24",
            67 => "Fronius Primo 15.0-1 208-240",
            68 => "Fronius Primo 12.5-1 208-240",
            69 => "Fronius Primo 11.4-1 208-240",
            70 => "Fronius Primo 10.0-1 208-240",
            71 => "Fronius Symo 15.0-3 208",
            72 => "Fronius Eco 27.0-3-S",
            73 => "Fronius Eco 25.0-3-S",
            75 => "Fronius Primo 6.0-1",
            76 => "Fronius Primo 5.0-1",
            77 => "Fronius Primo 4.6-1",
            78 => "Fronius Primo 4.0-1",
            79 => "Fronius Primo 3.6-1",
            80 => "Fronius Primo 3.5-1",
            81 => "Fronius Primo 3.0-1",
            82 => "Fronius Symo Hybrid 4.0-3-S",
            83 => "Fronius Symo Hybrid 3.0-3-S",
            84 => "Fronius IG Plus 120 V-1",
            85 => "Fronius Primo 3.8-1 208-240",
            86 => "Fronius Primo 5.0-1 208-240",
            87 => "Fronius Primo 6.0-1 208-240",
            88 => "Fronius Primo 7.6-1 208-240",
            89 => "Fronius Symo 24.0-3 USA Dummy",
            90 => "Fronius Symo 24.0-3 480",
            91 => "Fronius Symo 22.7-3 480",
            92 => "Fronius Symo 20.0-3 480",
            93 => "Fronius Symo 17.5-3 480",
            94 => "Fronius Symo 15.0-3 480",
            95 => "Fronius Symo 12.5-3 480",
            96 => "Fronius Symo 10.0-3 480",
            97 => "Fronius Symo 12.0-3 208-240",
            98 => "Fronius Symo 10.0-3 208-240",
            99 => "Fronius Symo Hybrid 5.0-3-S",
            100 => "Fronius Primo 8.2-1 Dummy",
            101 => "Fronius Primo 8.2-1 208-240",
            102 => "Fronius Primo 8.2-1",
            103 => "Fronius Agilo TL 360.0-3",
            104 => "Fronius Agilo TL 460.0-3",
            105 => "Fronius Symo 7.0-3-M",
            106 => "Fronius Galvo 3.1-1 208-240",
            107 => "Fronius Galvo 2.5-1 208-240",
            108 => "Fronius Galvo 2.0-1 208-240",
            109 => "Fronius Galvo 1.5-1 208-240",
            110 => "Fronius Symo 6.0-3-M",
            111 => "Fronius Symo 4.5-3-M",
            112 => "Fronius Symo 3.7-3-M",
            113 => "Fronius Symo 3.0-3-M",
            114 => "Fronius Symo 17.5-3-M",
            115 => "Fronius Symo 15.0-3-M",
            116 => "Fronius Agilo 75.0-3 Outdoor",
            117 => "Fronius Agilo 100.0-3 Outdoor",
            118 => "Fronius IG Plus 55 V-1",
            119 => "Fronius IG Plus 55 V-2",
            120 => "Fronius Symo 20.0-3 Dummy",
            121 => "Fronius Symo 20.0-3-M",
            122 => "Fronius Symo 5.0-3-M",
            123 => "Fronius Symo 8.2-3-M",
            124 => "Fronius Symo 6.7-3-M",
            125 => "Fronius Symo 5.5-3-M",
            126 => "Fronius Symo 4.5-3-S",
            127 => "Fronius Symo 3.7-3-S",
            128 => "Fronius IG Plus 60 V-2",
            129 => "Fronius IG Plus 60 V-1",
            130 => "SPR 8001F-3 EU",
            131 => "Fronius IG Plus 25 V-1",
            132 => "Fronius IG Plus 100 V-3",
            133 => "Fronius Agilo 100.0-3",
            134 => "SPR 3001F-1 EU",
            135 => "Fronius IG Plus V/A 10.0-3 Delta",
            136 => "Fronius IG 50",
            137 => "Fronius IG Plus 30 V-1",
            138 => "SPR-11401f-1 UNI",
            139 => "SPR-12001f-3 WYE277",
            140 => "SPR-11401f-3 Delta",
            141 => "SPR-10001f-1 UNI",
            142 => "SPR-7501f-1 UNI",
            143 => "SPR-6501f-1 UNI",
            144 => "SPR-3801f-1 UNI",
            145 => "SPR-3301f-1 UNI",
            146 => "SPR 12001F-3 EU",
            147 => "SPR 10001F-3 EU",
            148 => "SPR 8001F-2 EU",
            149 => "SPR 6501F-2 EU",
            150 => "SPR 4001F-1 EU",
            151 => "SPR 3501F-1 EU",
            152 => "Fronius CL 60.0 WYE277 Dummy",
            153 => "Fronius CL 55.5 Delta Dummy",
            154 => "Fronius CL 60.0 Dummy",
            155 => "Fronius IG Plus V 12.0-3 Dummy",
            156 => "Fronius IG Plus V 7.5-1 Dummy",
            157 => "Fronius IG Plus V 3.8-1 Dummy",
            158 => "Fronius IG Plus 150 V-3 Dummy",
            159 => "Fronius IG Plus 100 V-2 Dummy",
            160 => "Fronius IG Plus 50 V-1 Dummy",
            161 => "Fronius IG Plus V/A 12.0-3 WYE",
            162 => "Fronius IG Plus V/A 11.4-3 Delta",
            163 => "Fronius IG Plus V/A 11.4-1 UNI",
            164 => "Fronius IG Plus V/A 10.0-1 UNI",
            165 => "Fronius IG Plus V/A 7.5-1 UNI",
            166 => "Fronius IG Plus V/A 6.0-1 UNI",
            167 => "Fronius IG Plus V/A 5.0-1 UNI",
            168 => "Fronius IG Plus V/A 3.8-1 UNI",
            169 => "Fronius IG Plus V/A 3.0-1 UNI",
            170 => "Fronius IG Plus 150 V-3",
            171 => "Fronius IG Plus 120 V-3",
            172 => "Fronius IG Plus 100 V-2",
            173 => "Fronius IG Plus 100 V-1",
            174 => "Fronius IG Plus 70 V-2",
            175 => "Fronius IG Plus 70 V-1",
            176 => "Fronius IG Plus 50 V-1",
            177 => "Fronius IG Plus 35 V-1",
            178 => "SPR 11400f-3 208/240",
            179 => "SPR 12000f-277",
            180 => "SPR 10000f",
            181 => "SPR 10000F EU",
            182 => "Fronius CL 33.3 Delta",
            183 => "Fronius CL 44.4 Delta",
            184 => "Fronius CL 55.5 Delta",
            185 => "Fronius CL 36.0 WYE277",
            186 => "Fronius CL 48.0 WYE277",
            187 => "Fronius CL 60.0 WYE277",
            188 => "Fronius CL 36.0",
            189 => "Fronius CL 48.0",
            190 => "Fronius IG TL 3.0",
            191 => "Fronius IG TL 4.0",
            192 => "Fronius IG TL 5.0",
            193 => "Fronius IG TL 3.6",
            194 => "Fronius IG TL Dummy",
            195 => "Fronius IG TL 4.6",
            196 => "SPR 12000F EU",
            197 => "SPR 8000F EU",
            198 => "SPR 6500F EU",
            199 => "SPR 4000F EU",
            200 => "SPR 3300F EU",
            201 => "Fronius CL 60.0",
            202 => "SPR 12000f",
            203 => "SPR 8000f",
            204 => "SPR 6500f",
            205 => "SPR 4000f",
            206 => "SPR 3300f",
            207 => "Fronius IG Plus 12.0-3 WYE277",
            208 => "Fronius IG Plus 50",
            209 => "Fronius IG Plus 100",
            210 => "Fronius IG Plus 100",
            211 => "Fronius IG Plus 150",
            212 => "Fronius IG Plus 35",
            213 => "Fronius IG Plus 70",
            214 => "Fronius IG Plus 70",
            215 => "Fronius IG Plus 120",
            216 => "Fronius IG Plus 3.0-1 UNI",
            217 => "Fronius IG Plus 3.8-1 UNI",
            218 => "Fronius IG Plus 5.0-1 UNI",
            219 => "Fronius IG Plus 6.0-1 UNI",
            220 => "Fronius IG Plus 7.5-1 UNI",
            221 => "Fronius IG Plus 10.0-1 UNI",
            222 => "Fronius IG Plus 11.4-1 UNI",
            223 => "Fronius IG Plus 11.4-3 Delta",
            224 => "Fronius Galvo 3.0-1",
            225 => "Fronius Galvo 2.5-1",
            226 => "Fronius Galvo 2.0-1",
            227 => "Fronius IG 4500-LV",
            228 => "Fronius Galvo 1.5-1",
            229 => "Fronius IG 2500-LV",
            230 => "Fronius Agilo 75.0-3",
            231 => "Fronius Agilo 100.0-3 Dummy",
            232 => "Fronius Symo 10.0-3-M",
            233 => "Fronius Symo 12.5-3-M",
            234 => "Fronius IG 5100",
            235 => "Fronius IG 4000",
            236 => "Fronius Symo 8.2-3-M Dummy",
            237 => "Fronius IG 3000",
            238 => "Fronius IG 2000",
            239 => "Fronius Galvo 3.1-1 Dummy",
            240 => "Fronius IG Plus 80 V-3",
            241 => "Fronius IG Plus 60 V-3",
            242 => "Fronius IG Plus 55 V-3",
            243 => "Fronius IG 60 ADV",
            244 => "Fronius IG 500",
            245 => "Fronius IG 400",
            246 => "Fronius IG 300",
            247 => "Fronius Symo 3.0-3-S",
            248 => "Fronius Galvo 3.1-1",
            249 => "Fronius IG 60 HV",
            250 => "Fronius IG 40",
            251 => "Fronius IG 30 Dummy",
            252 => "Fronius IG 30",
            253 => "Fronius IG 20",
            254 => "Fronius IG 15",
            _ => Resources.Unknown
        };
    }
}