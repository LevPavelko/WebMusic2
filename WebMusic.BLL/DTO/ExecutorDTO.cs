﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMusic.BLL.DTO
{
    // Data Transfer Object - специальная модель для передачи данных
    // Класс PlayerDTO должен содержать только те данные, которые нужно передать 
    // на уровень представления или, наоборот, получить с этого уровня.
    public class ExecutorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
