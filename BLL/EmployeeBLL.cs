﻿using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetALL()
        {
            EmployeeDTO dto = new EmployeeDTO();
            dto.Departments = DepartmentDAO.GetDepartments();
            dto.Positions = PositionDAO.GetPositions();
            dto.Employees = EmployeeDAO.GetEmployees();
            return dto;
        }
        public static void AddEmployee(EMPLOYEE employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static bool isUnique(int userNo)
        {
            List<EMPLOYEE> list = EmployeeDAO.GetUsers(userNo);
            if (list.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static List<EMPLOYEE> GetEmployees(int v, string text)
        {
            return EmployeeDAO.GetEmployees(v, text);
        }
    }
}
