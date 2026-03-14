# 🌐 week3-aspnet-api

> ASP.NET Core REST API 서버 — 재학습 커리큘럼 3주차

[![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-512BD4?style=flat-square&logo=dotnet)]()
[![Swagger](https://img.shields.io/badge/Swagger-UI-85EA2D?style=flat-square&logo=swagger)](https://swagger.io/)
[![xUnit](https://img.shields.io/badge/Test-xUnit-FF4B4B?style=flat-square)]()
<!-- [![Status](https://img.shields.io/badge/Status-Complete-059669?style=flat-square)]() -->

---

## 📌 프로젝트 개요

2주차 WinForms 앱의 비즈니스 로직을 **REST API 서버로 분리**한 프로젝트입니다.
ASP.NET Core를 활용해 메모 CRUD API를 구현하고, 의존성 주입(DI), DTO 패턴, 단위 테스트까지 적용했습니다.

---

## 🗂️ 파일 구조

<!-- ```
week3-aspnet-api/
├── Controllers/
│   └── NotesController.cs     # REST 엔드포인트 정의
├── Services/
│   └── NoteService.cs         # 비즈니스 로직
├── Repositories/
│   └── NoteRepository.cs      # DB 접근 계층
├── Models/
│   ├── Note.cs                # 도메인 모델
│   └── NoteDto.cs             # 요청/응답 DTO
├── Tests/
│   └── NoteServiceTests.cs    # xUnit 단위 테스트
├── appsettings.json           # 환경 설정
├── Program.cs                 # 앱 진입점 + DI 등록
└── README.md
``` -->

---

## 🛠️ 기술 스택

| 항목 | 내용 |
|------|------|
| 언어 | C# 11.0 |
| 프레임워크 | ASP.NET Core 6.0 |
| 데이터베이스 | SQLite (Entity Framework Core) |
| API 문서화 | Swagger / OpenAPI |
| 테스트 | xUnit |
| DI | 기본 내장 DI 컨테이너 |

---

## 📡 API 명세

### Base URL
```
http://localhost:5000/api
```

### 엔드포인트 목록
<!-- 
| 메서드 | 경로 | 설명 | 상태코드 |
|--------|------|------|---------|
| `GET` | `/notes` | 전체 메모 조회 | 200 |
| `GET` | `/notes/{id}` | 단건 메모 조회 | 200 / 404 |
| `POST` | `/notes` | 메모 생성 | 201 |
| `PUT` | `/notes/{id}` | 메모 수정 | 200 / 404 |
| `DELETE` | `/notes/{id}` | 메모 삭제 | 204 / 404 | -->

---

### 요청 / 응답 예시

<!-- **POST /api/notes**
```json
// Request Body
{
  "title": "오늘의 할 일",
  "content": "C# 복습 완료하기"
}

// Response 201 Created
{
  "id": 1,
  "title": "오늘의 할 일",
  "content": "C# 복습 완료하기",
  "created": "2025-03-10T14:30:00"
}
```

**GET /api/notes/999 (없는 ID)**
```json
// Response 404 Not Found
{
  "message": "해당 메모를 찾을 수 없습니다. (id: 999)"
}
``` -->

---

## 🏗️ 아키텍처

```
Client (Postman / WinForms)
    │  HTTP 요청
    ▼
NotesController          ← 라우팅, HTTP 응답 코드 결정
    │  DI로 주입
    ▼
NoteService              ← 유효성 검사, 비즈니스 규칙
    │  DI로 주입
    ▼
NoteRepository           ← EF Core, DB 쿼리
    │
    ▼
SQLite DB
```

---

## ⚙️ 핵심 구현 포인트

<!-- ### 의존성 주입 (Program.cs)

```csharp
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddScoped<INoteService, NoteService>();
``` -->

---

<!-- ### DTO 패턴 적용

```csharp
// 요청용 DTO (외부 노출 최소화)
public record NoteDto(string Title, string Content);

// 도메인 모델 (내부 전용)
public class Note {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime Created { get; set; }
}
```

--- -->

<!-- ### 단위 테스트 (xUnit)

```csharp
[Fact]
public void GetById_ExistingId_ReturnsNote()
{
    var note = _service.GetById(1);
    Assert.NotNull(note);
    Assert.Equal("테스트 메모", note!.Title);
}

[Fact]
public void GetById_InvalidId_ReturnsNull()
{
    var note = _service.GetById(999);
    Assert.Null(note);
}
``` -->

---

## ▶️ 실행 방법

```bash
# 저장소 클론
git clone https://github.com/[YOUR_USERNAME]/week3-aspnet-api.git
cd week3-aspnet-api

# 패키지 복원
dotnet restore

# DB 마이그레이션 (EF Core 사용 시)
dotnet ef database update

# 서버 실행
dotnet run
```

> 실행 후 브라우저에서 Swagger UI 확인:
> `http://localhost:5000/swagger`

---

### 테스트 실행

```bash
cd Tests
dotnet test
```
---

## 💡 트러블슈팅

<!-- 실제 겪은 문제를 작성하세요 -->

<!-- **문제:** POST 요청 시 Body 데이터가 null로 들어오는 현상
**원인:** `[ApiController]` 어트리뷰트 없이 `[FromBody]` 바인딩이 동작하지 않음
**해결:** 컨트롤러에 `[ApiController]` 추가, Content-Type `application/json` 헤더 확인 -->

---

## 📅 학습 기간

- 시작일: `YYYY-MM-DD`
- 완료일: `YYYY-MM-DD`
- 소요 시간: 약 XX시간

---

## 🔗 관련 링크

- [이전 단계 ← week2-winforms-crud](../week2-winforms-crud)
- [다음 단계 → week4-portfolio](../week4-portfolio)
- [Swagger UI](http://localhost:5000/swagger)
- [커리큘럼 전체 보기](../README.md)