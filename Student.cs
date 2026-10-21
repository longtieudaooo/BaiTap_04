using System;

namespace Bai_tap_04
{
    public class Student
    {
        public string StudentId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = "Nam";
        public string AvatarPath { get; set; } = string.Empty;

        public Student() { }

        public Student(string studentId, string fullName, int age, string gender, string avatarPath)
        {
            StudentId = studentId;
            FullName = fullName;
            Age = age;
            Gender = gender;
            AvatarPath = avatarPath;
        }

        // Định dạng xuất dòng CSV
        public string ToCsvRow()
        {
            return $"\"{StudentId}\",\"{FullName}\",{Age},\"{Gender}\",\"{AvatarPath}\"";
        }

        // Đọc dữ liệu từ dòng CSV
        public static Student FromCsvRow(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            if (parts.Length >= 5)
            {
                return new Student(
                    parts[0].Trim('"'),
                    parts[1].Trim('"'),
                    int.TryParse(parts[2], out int age) ? age : 18,
                    parts[3].Trim('"'),
                    parts[4].Trim('"')
                );
            }
            return new Student();
        }
    }
}