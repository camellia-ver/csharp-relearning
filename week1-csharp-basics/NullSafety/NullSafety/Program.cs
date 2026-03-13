static void Main()
{
    //Console.Write("이름을 입력하세요: ");
    //string? input = Console.ReadLine();

    //string displayName = input ?? "이름없음";
    //Console.WriteLine(displayName);

    // 설정 파일에서 읽어온 값 (없으면 null)
    string? theme = GetSetting("theme");
    int? fontSize = GetSettingInt("fontSize");
    bool? darkMode = GetSettingBool("darkMode");

    theme ??= "light";
    fontSize ??= 14;
    darkMode ??= false;

    Console.WriteLine($"{theme} {fontSize} {darkMode}");
}

static string? GetSetting(string key) => null;
static int? GetSettingInt(string key) => null;
static bool? GetSettingBool(string key) => null;