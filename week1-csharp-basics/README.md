# 📘 week1-csharp-basics

> C# 언어 핵심 문법 복습 프로젝트 — 재학습 커리큘럼 1주차

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat-square&logo=c-sharp)](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
<!-- [![Status](https://img.shields.io/badge/Status-Complete-059669?style=flat-square)]() -->

---

## 📌 프로젝트 개요

C# 실무 경험 이후 공백기를 거치며, 백엔드 개발자로 전환하기 위한 **자기주도 재학습 커리큘럼**의 1주차 산출물입니다.
언어 핵심 문법(LINQ, async/await, OOP, Null 안전 처리)을 콘솔 앱 형태로 직접 구현하며 복습했습니다.

---

## 🗂️ 파일 구조

```
week1-csharp-basics/
├── StudentManager.cs     # LINQ를 활용한 학생 성적 관리
├── AsyncDemo.cs          # async/await 비동기 패턴 실습
├── OopExercise.cs        # 인터페이스 + 상속 OOP 실습
├── NullSafety.cs         # ??, ?., ??= Null 안전 처리
└── README.md
```

---

## 🛠️ 기술 스택

| 항목 | 내용 |
|------|------|
| 언어 | C# 11.0 |
| 프레임워크 | .NET 8.0 |
| 실행 방식 | Console Application |
| 개발 환경 | Visual Studio 2022 / VS Code |

---

## 📂 파일별 설명

### `StudentManager.cs` — LINQ 실습
<!-- - `List<Student>` 컬렉션을 LINQ로 필터링, 정렬, 집계
- `Where`, `Select`, `OrderByDescending`, `Average`, `GroupBy` 사용
- 학습 포인트: 메서드 체이닝, 지연 실행(Deferred Execution)

```csharp
// 60점 이상인 학생을 점수 내림차순으로 출력
var passed = students
    .Where(s => s.Score >= 60)
    .OrderByDescending(s => s.Score);
``` -->

---

### `AsyncDemo.cs` — 비동기 처리 실습
<!-- - `async/await` 패턴을 적용한 메서드 3개 이상 구현
- `Task`, `Task<T>` 반환형 차이 실습
- 학습 포인트: 비동기 흐름 제어, deadlock 방지

```csharp
private static async Task<List<string>> LoadDataAsync()
{
    await Task.Delay(1000); // I/O 대기 시뮬레이션
    return new List<string> { "데이터1", "데이터2" };
}
``` -->

---

### `OopExercise.cs` — 객체지향 실습
<!-- - `IAnimal` 인터페이스 정의 및 `Dog`, `Cat` 클래스 구현

```csharp
interface IAnimal {
    string Name { get; }
    void Speak();
}

class Dog : IAnimal {
    public string Name { get; } = "강아지";
    public void Speak() => Console.WriteLine("멍!");
}
``` -->

---

### `NullSafety.cs` — Null 안전 처리
<!-- - `??`, `?.`, `??=` 연산자 활용
- Nullable 참조 타입(`string?`) 처리 패턴
- 학습 포인트: NullReferenceException 방지 전략

```csharp
string? city = user.Address?.City ?? "미등록";
``` -->

---

## ▶️ 실행 방법

```bash
# 저장소 클론
git clone https://github.com/camellia-ver/week1-csharp-basics.git
cd week1-csharp-basics

# 빌드 및 실행 (.NET SDK 6.0 이상 필요)
dotnet run
```

---

## ✅ 학습 체크리스트

- [ ] LINQ 핵심 메서드 5가지 이상 직접 작성
- [ ] async/await 메서드 3개 이상 구현
- [ ] 인터페이스 정의 + 구현 클래스 2개 이상
- [ ] Null 안전 연산자 3가지 실제 코드에 적용
- [ ] 단위 테스트 추가 (2주차 이후 보완 예정)

---

## 💡 학습 후기 / 트러블슈팅

<!-- 실제 겪은 문제와 해결 과정을 작성하세요. 면접에서 좋은 소재가 됩니다. -->

<!-- **문제:** `async` 메서드를 `void`로 선언했을 때 예외가 catch되지 않는 현상
**원인:** `async void`는 예외가 호출자에게 전파되지 않음
**해결:** 이벤트 핸들러 외에는 반드시 `async Task`로 선언하도록 수정 -->

---

## 📅 학습 기간

- 시작일: `2026-03-11`
- 완료일: `2026-03-DD`

---

## 🔗 관련 링크

- [다음 단계 → week2-winforms-crud](../week2-winforms-crud)
- [C# 공식 문서](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
- [커리큘럼 전체 보기](../README.md)