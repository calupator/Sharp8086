﻿namespace Sharp8086.Peripheral.Graphics
{
    internal static class GraphicsFont
    {
        public static readonly byte[] Font8X8 =
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x7e, 0x81, 0xa5, 0x81, 0xbd, 0x99, 0x81, 0x7e,
            0x7e, 0xff, 0xdb, 0xff, 0xc3, 0xe7, 0xff, 0x7e,
            0x6c, 0xfe, 0xfe, 0xfe, 0x7c, 0x38, 0x10, 0x00,
            0x10, 0x38, 0x7c, 0xfe, 0x7c, 0x38, 0x10, 0x00,
            0x38, 0x7c, 0x38, 0xfe, 0xfe, 0x7c, 0x38, 0x7c,
            0x10, 0x10, 0x38, 0x7c, 0xfe, 0x7c, 0x38, 0x7c,
            0x00, 0x00, 0x18, 0x3c, 0x3c, 0x18, 0x00, 0x00,
            0xff, 0xff, 0xe7, 0xc3, 0xc3, 0xe7, 0xff, 0xff,
            0x00, 0x3c, 0x66, 0x42, 0x42, 0x66, 0x3c, 0x00,
            0xff, 0xc3, 0x99, 0xbd, 0xbd, 0x99, 0xc3, 0xff,
            0x0f, 0x07, 0x0f, 0x7d, 0xcc, 0xcc, 0xcc, 0x78,
            0x3c, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x7e, 0x18,
            0x3f, 0x33, 0x3f, 0x30, 0x30, 0x70, 0xf0, 0xe0,
            0x7f, 0x63, 0x7f, 0x63, 0x63, 0x67, 0xe6, 0xc0,
            0x99, 0x5a, 0x3c, 0xe7, 0xe7, 0x3c, 0x5a, 0x99,
            0x80, 0xe0, 0xf8, 0xfe, 0xf8, 0xe0, 0x80, 0x00,
            0x02, 0x0e, 0x3e, 0xfe, 0x3e, 0x0e, 0x02, 0x00,
            0x18, 0x3c, 0x7e, 0x18, 0x18, 0x7e, 0x3c, 0x18,
            0x66, 0x66, 0x66, 0x66, 0x66, 0x00, 0x66, 0x00,
            0x7f, 0xdb, 0xdb, 0x7b, 0x1b, 0x1b, 0x1b, 0x00,
            0x3e, 0x63, 0x38, 0x6c, 0x6c, 0x38, 0xcc, 0x78,
            0x00, 0x00, 0x00, 0x00, 0x7e, 0x7e, 0x7e, 0x00,
            0x18, 0x3c, 0x7e, 0x18, 0x7e, 0x3c, 0x18, 0xff,
            0x18, 0x3c, 0x7e, 0x18, 0x18, 0x18, 0x18, 0x00,
            0x18, 0x18, 0x18, 0x18, 0x7e, 0x3c, 0x18, 0x00,
            0x00, 0x18, 0x0c, 0xfe, 0x0c, 0x18, 0x00, 0x00,
            0x00, 0x30, 0x60, 0xfe, 0x60, 0x30, 0x00, 0x00,
            0x00, 0x00, 0xc0, 0xc0, 0xc0, 0xfe, 0x00, 0x00,
            0x00, 0x24, 0x66, 0xff, 0x66, 0x24, 0x00, 0x00,
            0x00, 0x18, 0x3c, 0x7e, 0xff, 0xff, 0x00, 0x00,
            0x00, 0xff, 0xff, 0x7e, 0x3c, 0x18, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x30, 0x78, 0x78, 0x30, 0x30, 0x00, 0x30, 0x00,
            0x6c, 0x6c, 0x6c, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x6c, 0x6c, 0xfe, 0x6c, 0xfe, 0x6c, 0x6c, 0x00,
            0x30, 0x7c, 0xc0, 0x78, 0x0c, 0xf8, 0x30, 0x00,
            0x00, 0xc6, 0xcc, 0x18, 0x30, 0x66, 0xc6, 0x00,
            0x38, 0x6c, 0x38, 0x76, 0xdc, 0xcc, 0x76, 0x00,
            0x60, 0x60, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x18, 0x30, 0x60, 0x60, 0x60, 0x30, 0x18, 0x00,
            0x60, 0x30, 0x18, 0x18, 0x18, 0x30, 0x60, 0x00,
            0x00, 0x66, 0x3c, 0xff, 0x3c, 0x66, 0x00, 0x00,
            0x00, 0x30, 0x30, 0xfc, 0x30, 0x30, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x30, 0x60,
            0x00, 0x00, 0x00, 0xfc, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x30, 0x00,
            0x06, 0x0c, 0x18, 0x30, 0x60, 0xc0, 0x80, 0x00,
            0x7c, 0xc6, 0xce, 0xde, 0xf6, 0xe6, 0x7c, 0x00,
            0x30, 0x70, 0x30, 0x30, 0x30, 0x30, 0xfc, 0x00,
            0x78, 0xcc, 0x0c, 0x38, 0x60, 0xcc, 0xfc, 0x00,
            0x78, 0xcc, 0x0c, 0x38, 0x0c, 0xcc, 0x78, 0x00,
            0x1c, 0x3c, 0x6c, 0xcc, 0xfe, 0x0c, 0x1e, 0x00,
            0xfc, 0xc0, 0xf8, 0x0c, 0x0c, 0xcc, 0x78, 0x00,
            0x38, 0x60, 0xc0, 0xf8, 0xcc, 0xcc, 0x78, 0x00,
            0xfc, 0xcc, 0x0c, 0x18, 0x30, 0x30, 0x30, 0x00,
            0x78, 0xcc, 0xcc, 0x78, 0xcc, 0xcc, 0x78, 0x00,
            0x78, 0xcc, 0xcc, 0x7c, 0x0c, 0x18, 0x70, 0x00,
            0x00, 0x30, 0x30, 0x00, 0x00, 0x30, 0x30, 0x00,
            0x00, 0x30, 0x30, 0x00, 0x00, 0x30, 0x30, 0x60,
            0x18, 0x30, 0x60, 0xc0, 0x60, 0x30, 0x18, 0x00,
            0x00, 0x00, 0xfc, 0x00, 0x00, 0xfc, 0x00, 0x00,
            0x60, 0x30, 0x18, 0x0c, 0x18, 0x30, 0x60, 0x00,
            0x78, 0xcc, 0x0c, 0x18, 0x30, 0x00, 0x30, 0x00,
            0x7c, 0xc6, 0xde, 0xde, 0xde, 0xc0, 0x78, 0x00,
            0x30, 0x78, 0xcc, 0xcc, 0xfc, 0xcc, 0xcc, 0x00,
            0xfc, 0x66, 0x66, 0x7c, 0x66, 0x66, 0xfc, 0x00,
            0x3c, 0x66, 0xc0, 0xc0, 0xc0, 0x66, 0x3c, 0x00,
            0xf8, 0x6c, 0x66, 0x66, 0x66, 0x6c, 0xf8, 0x00,
            0xfe, 0x62, 0x68, 0x78, 0x68, 0x62, 0xfe, 0x00,
            0xfe, 0x62, 0x68, 0x78, 0x68, 0x60, 0xf0, 0x00,
            0x3c, 0x66, 0xc0, 0xc0, 0xce, 0x66, 0x3e, 0x00,
            0xcc, 0xcc, 0xcc, 0xfc, 0xcc, 0xcc, 0xcc, 0x00,
            0x78, 0x30, 0x30, 0x30, 0x30, 0x30, 0x78, 0x00,
            0x1e, 0x0c, 0x0c, 0x0c, 0xcc, 0xcc, 0x78, 0x00,
            0xe6, 0x66, 0x6c, 0x78, 0x6c, 0x66, 0xe6, 0x00,
            0xf0, 0x60, 0x60, 0x60, 0x62, 0x66, 0xfe, 0x00,
            0xc6, 0xee, 0xfe, 0xfe, 0xd6, 0xc6, 0xc6, 0x00,
            0xc6, 0xe6, 0xf6, 0xde, 0xce, 0xc6, 0xc6, 0x00,
            0x38, 0x6c, 0xc6, 0xc6, 0xc6, 0x6c, 0x38, 0x00,
            0xfc, 0x66, 0x66, 0x7c, 0x60, 0x60, 0xf0, 0x00,
            0x78, 0xcc, 0xcc, 0xcc, 0xdc, 0x78, 0x1c, 0x00,
            0xfc, 0x66, 0x66, 0x7c, 0x6c, 0x66, 0xe6, 0x00,
            0x78, 0xcc, 0xe0, 0x70, 0x1c, 0xcc, 0x78, 0x00,
            0xfc, 0xb4, 0x30, 0x30, 0x30, 0x30, 0x78, 0x00,
            0xcc, 0xcc, 0xcc, 0xcc, 0xcc, 0xcc, 0xfc, 0x00,
            0xcc, 0xcc, 0xcc, 0xcc, 0xcc, 0x78, 0x30, 0x00,
            0xc6, 0xc6, 0xc6, 0xd6, 0xfe, 0xee, 0xc6, 0x00,
            0xc6, 0xc6, 0x6c, 0x38, 0x38, 0x6c, 0xc6, 0x00,
            0xcc, 0xcc, 0xcc, 0x78, 0x30, 0x30, 0x78, 0x00,
            0xfe, 0xc6, 0x8c, 0x18, 0x32, 0x66, 0xfe, 0x00,
            0x78, 0x60, 0x60, 0x60, 0x60, 0x60, 0x78, 0x00,
            0xc0, 0x60, 0x30, 0x18, 0x0c, 0x06, 0x02, 0x00,
            0x78, 0x18, 0x18, 0x18, 0x18, 0x18, 0x78, 0x00,
            0x10, 0x38, 0x6c, 0xc6, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff,
            0x30, 0x30, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x78, 0x0c, 0x7c, 0xcc, 0x76, 0x00,
            0xe0, 0x60, 0x60, 0x7c, 0x66, 0x66, 0xdc, 0x00,
            0x00, 0x00, 0x78, 0xcc, 0xc0, 0xcc, 0x78, 0x00,
            0x1c, 0x0c, 0x0c, 0x7c, 0xcc, 0xcc, 0x76, 0x00,
            0x00, 0x00, 0x78, 0xcc, 0xfc, 0xc0, 0x78, 0x00,
            0x38, 0x6c, 0x60, 0xf0, 0x60, 0x60, 0xf0, 0x00,
            0x00, 0x00, 0x76, 0xcc, 0xcc, 0x7c, 0x0c, 0xf8,
            0xe0, 0x60, 0x6c, 0x76, 0x66, 0x66, 0xe6, 0x00,
            0x30, 0x00, 0x70, 0x30, 0x30, 0x30, 0x78, 0x00,
            0x0c, 0x00, 0x0c, 0x0c, 0x0c, 0xcc, 0xcc, 0x78,
            0xe0, 0x60, 0x66, 0x6c, 0x78, 0x6c, 0xe6, 0x00,
            0x70, 0x30, 0x30, 0x30, 0x30, 0x30, 0x78, 0x00,
            0x00, 0x00, 0xcc, 0xfe, 0xfe, 0xd6, 0xc6, 0x00,
            0x00, 0x00, 0xf8, 0xcc, 0xcc, 0xcc, 0xcc, 0x00,
            0x00, 0x00, 0x78, 0xcc, 0xcc, 0xcc, 0x78, 0x00,
            0x00, 0x00, 0xdc, 0x66, 0x66, 0x7c, 0x60, 0xf0,
            0x00, 0x00, 0x76, 0xcc, 0xcc, 0x7c, 0x0c, 0x1e,
            0x00, 0x00, 0xdc, 0x76, 0x66, 0x60, 0xf0, 0x00,
            0x00, 0x00, 0x7c, 0xc0, 0x78, 0x0c, 0xf8, 0x00,
            0x10, 0x30, 0x7c, 0x30, 0x30, 0x34, 0x18, 0x00,
            0x00, 0x00, 0xcc, 0xcc, 0xcc, 0xcc, 0x76, 0x00,
            0x00, 0x00, 0xcc, 0xcc, 0xcc, 0x78, 0x30, 0x00,
            0x00, 0x00, 0xc6, 0xd6, 0xfe, 0xfe, 0x6c, 0x00,
            0x00, 0x00, 0xc6, 0x6c, 0x38, 0x6c, 0xc6, 0x00,
            0x00, 0x00, 0xcc, 0xcc, 0xcc, 0x7c, 0x0c, 0xf8,
            0x00, 0x00, 0xfc, 0x98, 0x30, 0x64, 0xfc, 0x00,
            0x1c, 0x30, 0x30, 0xe0, 0x30, 0x30, 0x1c, 0x00,
            0x18, 0x18, 0x18, 0x00, 0x18, 0x18, 0x18, 0x00,
            0xe0, 0x30, 0x30, 0x1c, 0x30, 0x30, 0xe0, 0x00,
            0x76, 0xdc, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x10, 0x38, 0x6c, 0xc6, 0xc6, 0xfe, 0x00
        };
    }
}