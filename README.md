# 🎯 csharp-relearning

> C# 재학습 커리큘럼 전체 저장소 — Windows App 개발자의 백엔드 전환 기록

[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat-square&logo=c-sharp)](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![진행률](https://img.shields.io/badge/진행률-1/4_미완료-059669?style=flat-square)]()

---

## 👤 소개

| 항목 | 내용 |
|------|------|
| 학력 | 컴퓨터공학과 학사 |
| 경력 | Windows App 개발 (C#, WinForms) 9개월 |
| 목표 | 백엔드 개발자 취업 |
| 학습 기간 | `2026-03-11` ~ `2026-MM-DD` (총 4주) |

> Windows App 개발 경험을 바탕으로 **ASP.NET Core 백엔드 및 REST API** 개발로 역량을 확장하기 위한 자기주도 재학습 커리큘럼입니다. 각 주차별 산출물을 직접 구현하며 실무 전환을 준비했습니다.

---

## 🗺️ 커리큘럼 로드맵

```
Week 1                Week 2                Week 3                Week 4
────────────          ────────────          ────────────          ────────────
C# 언어 핵심    →     WinForms + DB   →     REST API       →     통합 포트폴리오
                                            (ASP.NET Core)
LINQ                  ADO.NET               Controller            WinForms ↔ API
async/await           3-Tier 구조           DI 패턴               JWT 인증
OOP                   CRUD 앱               DTO                   GitHub Actions
Null 안전             유효성 검사           xUnit 테스트          Docker
```

---

## 📁 저장소 구조

| 폴더 | 내용 | 상태 |
|------|------|------|
| [week1-csharp-basics](./week1-csharp-basics) | C# 문법 핵심 복습 (Console 앱) | ✅ 완료 |
| [week2-winforms-crud](./week2-winforms-crud) | WinForms + SQLite CRUD 앱 | 미완료 |
| [week3-aspnet-api](./week3-aspnet-api) | ASP.NET Core REST API 서버 | 미완료 |
| [portfolio-csharp](./portfolio-csharp) | WinForms + API 통합 포트폴리오 | 미완료 |
<!-- ✅ 완료 -->
---

## 🛠️ 학습한 기술 스택

### 언어 / 프레임워크
- **C# 11.0** — LINQ, async/await, Nullable, Record 등 현대 문법
- **.NET 8.0** — WinForms, ASP.NET Core
- **ASP.NET Core** — REST API, DI, Middleware, JWT 인증

### 데이터베이스
- **SQLite** — 로컬 개발 및 테스트
- **ADO.NET** — 로우레벨 DB 접근
- **Entity Framework Core** — ORM

### 인프라 / 도구
- **GitHub Actions** — CI/CD 파이프라인
- **Docker** — 컨테이너화
- **Swagger / OpenAPI** — API 문서 자동화
- **xUnit** — 단위 테스트

---

## 📊 주차별 핵심 학습 내용

### ✅ 1주차 — C# 언어 핵심

```csharp
// LINQ: 한 줄로 필터 + 정렬 + 집계
var result = students
    .Where(s => s.Score >= 60)
    .OrderByDescending(s => s.Score)
    .Select(s => s.Name);

// Null 안전: NullReferenceException 방지
string city = user.Address?.City ?? "미등록";
```

### ✅ 2주차 — WinForms + DB

```
UI (MainForm) → BL (NoteService) → DAL (NoteRepository) → SQLite
SQL Injection 방지를 위한 파라미터 바인딩 적용
async/await로 UI 블로킹 없는 DB 조회 구현
```

### ✅ 3주차 — REST API

```
GET    /api/notes       → 전체 조회 (200 OK)
POST   /api/notes       → 생성 (201 Created)
PUT    /api/notes/{id}  → 수정 (200 OK / 404 Not Found)
DELETE /api/notes/{id}  → 삭제 (204 No Content)
```

### ✅ 4주차 — 통합 포트폴리오

```
WinForms → HttpClient → JWT 인증 → ASP.NET Core API → EF Core → SQLite
GitHub Actions CI: push 시 자동 빌드 + 테스트
```

---

## 💡 이 저장소를 만든 이유

Windows App 개발 경험 이후 공백기 동안 단순히 개념 공부에 그치지 않고,
**"동작하는 코드"** 로 역량을 증명하기 위해 각 단계별 산출물을 GitHub에 기록했습니다.

- 완성된 코드 > 기획만 있는 대형 프로젝트
- 단계별 커밋 히스토리로 학습 과정 투명하게 공개
- 트러블슈팅 경험을 README에 기록하여 문서화 습관 형성

---

## 📅 전체 학습 일정

| 주차 | 기간  완료 기준 |
|------|------|----------|
| 1주차 | `03/11 ~ 03/13` | Console 앱 4개 파일 GitHub 업로드 |
| 2주차 | `MM/DD ~ MM/DD` | WinForms 앱 실행 + 스크린샷 포함 |
| 3주차 | `MM/DD ~ MM/DD` | Swagger 확인 가능 + 테스트 통과 |
| 4주차 | `MM/DD ~ MM/DD` | 전체 통합 동작 + CI 통과 |

---

## 🔗 참고 자료

- [Microsoft Learn C#](https://learn.microsoft.com/ko-kr/dotnet/csharp/)
- [ASP.NET Core 공식 문서](https://learn.microsoft.com/ko-kr/aspnet/core/)
- [Entity Framework Core](https://learn.microsoft.com/ko-kr/ef/core/)
- [xUnit 문서](https://xunit.net/)

---

## 📬 연락처

- GitHub: [github.com/camellia-ver](https://github.com/camellia-ver)
<!-- - 이메일: `[이메일 주소]` -->
<!-- - 블로그: `[기술 블로그 URL]` -->
