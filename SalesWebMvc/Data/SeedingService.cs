using Microsoft.EntityFrameworkCore.Internal;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.Seller.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Alice Johnson", "alice@gmail.com", new DateTime(1990, 7, 15), 1500.0, d2);
            Seller s3 = new Seller(3, "Charlie Davis", "charlie@gmail.com", new DateTime(1985, 12, 8), 1200.0, d3);
            Seller s4 = new Seller(4, "David Smith", "david@gmail.com", new DateTime(1995, 3, 30), 1300.0, d1);
            Seller s5 = new Seller(5, "Eva Wilson", "eva@gmail.com", new DateTime(1982, 9, 5), 1100.0, d2);
            Seller s6 = new Seller(6, "Frank Miller", "frank@gmail.com", new DateTime(1993, 6, 18), 1400.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11000.00, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 10, 15), 8000.00, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 10, 22), 5000.00, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 11, 5), 12000.00, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 11, 10), 6000.00, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 11, 15), 9000.00, SaleStatus.Pending, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 12, 1), 7500.00, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 12, 7), 3000.00, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 12, 15), 11000.00, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 12, 22), 5000.00, SaleStatus.Canceled, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 1, 5), 8000.00, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 1, 10), 4000.00, SaleStatus.Pending, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 1, 15), 9000.00, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 2, 1), 12000.00, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 2, 7), 3000.00, SaleStatus.Pending, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 2, 15), 11000.00, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 2, 22), 5000.00, SaleStatus.Canceled, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 3, 5), 8000.00, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 3, 10), 4000.00, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 3, 15), 9000.00, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 9, 5), 9500.00, SaleStatus.Billed, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 9, 10), 4000.00, SaleStatus.Pending, s6);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 9, 15), 7500.00, SaleStatus.Billed, s1);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 10, 1), 3000.00, SaleStatus.Canceled, s2);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 10, 7), 8500.00, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 10, 15), 6000.00, SaleStatus.Pending, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 11, 1), 12000.00, SaleStatus.Billed, s5);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 11, 7), 5000.00, SaleStatus.Canceled, s6);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 11, 15), 9500.00, SaleStatus.Billed, s1);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 12, 1), 4000.00, SaleStatus.Pending, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2019, 12, 7), 8500.00, SaleStatus.Billed, s3);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2019, 12, 15), 6000.00, SaleStatus.Pending, s4);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2020, 1, 1), 12000.00, SaleStatus.Billed, s5);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2020, 1, 7), 5000.00, SaleStatus.Canceled, s6);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2020, 1, 15), 9500.00, SaleStatus.Billed, s1);
            SalesRecord r36 = new SalesRecord(36, new DateTime(2020, 2, 1), 4000.00, SaleStatus.Pending, s2);
            SalesRecord r37 = new SalesRecord(37, new DateTime(2020, 2, 7), 8500.00, SaleStatus.Billed, s3);
            SalesRecord r38 = new SalesRecord(38, new DateTime(2020, 2, 15), 6000.00, SaleStatus.Pending, s4);
            SalesRecord r39 = new SalesRecord(39, new DateTime(2020, 3, 1), 12000.00, SaleStatus.Billed, s5);
            SalesRecord r40 = new SalesRecord(40, new DateTime(2020, 3, 7), 5000.00, SaleStatus.Canceled, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40);

            _context.SaveChanges();
        }
    }
}
