﻿using Infrastructure;
using Infrastructure.Domain;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestRepository
{
    [TestFixture]
    public class RepositoryTest
    {
        private DbContextOptions<EFCoreDBContext> _dbContextOptions;
        private EFCoreDBContext _context;

        [SetUp]
        public void Setup()
        {
            _dbContextOptions = new DbContextOptionsBuilder<EFCoreDBContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new EFCoreDBContext(_dbContextOptions);
        }

        [Test]
        public async Task AddAsync_ShouldAddEntity()
        {
            var repository = new Repository<Invoice>(_context);
            var invoice = new Invoice { CustomerAddress = "Test Customer 1", Id = 1, InvoiceNumber = "Test Invoice 1", BusinessAddress = "Test Business 1" };

            repository.Add(invoice);

            var addedInvoice = _context.Invoices.Find(1);

            Assert.That(addedInvoice, Is.Not.Null,"Valid");
        }
    }
}
