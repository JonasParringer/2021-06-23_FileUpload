﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_23_FileUpload.Models;

    public class FileUploadContext : DbContext
    {
    public FileUploadContext()
    {
    }

    public FileUploadContext (DbContextOptions<FileUploadContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_23_FileUpload.Models.Document> Document { get; set; }
    }
