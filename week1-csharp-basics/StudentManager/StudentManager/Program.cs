using StudentManager;

StudentManagement studentManagement = new StudentManagement();
string selectNum = "1";

while (!selectNum.Equals("0"))
{
    Console.WriteLine("=== 학생 성적 관리 ===\r\n1. 학생 추가\r\n2. 학생 삭제\r\n3. 성적 조회\r\n4. 합계/평균\r\n5. 정렬\r\n0. 종료\r\n");

    Console.Write("선택:");
    selectNum = Console.ReadLine();
    string name = null;

    switch (selectNum)
    {
        case "1":
            Console.Write("이름: ");
            name = Console.ReadLine();
            Console.Write("점수: ");
            if (!int.TryParse(Console.ReadLine(), out int score))
            {
                Console.WriteLine("올바른 숫자를 입력하세요.");
                break;
            }

            studentManagement.AddStudent(new Student(name, score));

            Console.WriteLine("학생이 추가되었습니다.");
            break;
        case "2":
            Console.Write("이름: ");
            name = Console.ReadLine();

            if(studentManagement.RemoveStudent(name))
                Console.WriteLine("학생이 삭제되었습니다.");
            else
                Console.WriteLine("해당 학생을 찾을 수 없습니다.");
            break;
        case "3":
            Console.Write("이름: ");
            name = Console.ReadLine();

            foreach(int n in studentManagement.SearchScore(name))
            {
                Console.WriteLine($"점수: {n}");
            }
            break;
        case "4":
            studentManagement.PrintSumAndAvg();
            break;
        case "5":
            studentManagement.SortingScore();
            break;
        default:
            break;
    }
}