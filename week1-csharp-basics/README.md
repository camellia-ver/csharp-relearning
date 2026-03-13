# 📘 week1-csharp-basics

> C# 언어 핵심 문법 복습 프로젝트 — 재학습 커리큘럼 1주차

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat-square&logo=c-sharp)](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
[![Status](https://img.shields.io/badge/Status-Complete-059669?style=flat-square)]() 

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
| 개발 환경 | Visual Studio 2022 |

---

## 📂 파일별 설명

### `StudentManager.cs` — LINQ 실습
- `List<Student>` 컬렉션을 LINQ로 필터링, 정렬, 집계



---

### `AsyncDemo.cs` — 비동기 처리 실습
- `async/await` 패턴을 적용한 메서드 3개 이상 구현
- `Task`, `Task<T>` 반환형 차이 실습

---

### `OopExercise.cs` — 객체지향 실습
- `IAnimal` 인터페이스 정의 및 `Dog`, `Cat` 클래스 구현

```csharp
interface IAnimal {
    string Name { get; }
    void Speak();
}

class Dog : IAnimal {
    public string Name { get; } = "강아지";
    public void Speak() => Console.WriteLine("멍!");
}
```

---

### `NullSafety.cs` — Null 안전 처리
- `??`, `?.` 연산자 활용

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

## 💡 학습 후기 / 트러블슈팅

<!-- 실제 겪은 문제와 해결 과정을 작성하세요. 면접에서 좋은 소재가 됩니다. -->
**주의사항** : 코드구현시 반복문이나 분기문을 사용하는 쪽이 익숙해서 LINQ를 사용하지 않고 구현하려는 경향이 있음으로 C# 사용시에는 이부분을 의식하면서 개발하기

---

## 📅 학습 기간

- 시작일: `2026-03-11`
- 완료일: `2026-03-13`

---

## 🔗 관련 링크

- [다음 단계 → week2-winforms-crud](../week2-winforms-crud)
- [C# 공식 문서](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
- [커리큘럼 전체 보기](../README.md)
