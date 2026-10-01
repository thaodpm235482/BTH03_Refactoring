using System;
using System.Linq;

namespace Pattern09_SubstituteAlgorithm._3_Real
{
    internal class RealExample
    {
        public void ValidateUserRole(string userRole)
        {
            string[] validRoles = { "Admin", "Manager", "Supervisor" };

            // Sử dụng LINQ ngắn gọn và hiện đại thay cho việc duyệt vòng lặp
            bool hasAccess = validRoles.Contains(userRole, StringComparer.OrdinalIgnoreCase);

            if (hasAccess)
            {
                Console.WriteLine($"Quyền [{userRole}] HỢP LỆ. Cho phép truy cập hệ thống.");
            }
            else
            {
                Console.WriteLine($"Quyền [{userRole}] KHÔNG HỢP LỆ. Từ chối truy cập.");
            }
        }
    }
}
