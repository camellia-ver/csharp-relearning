# 🪟 week2-winforms-crud

> WinForms + SQLite 기반 메모 관리 데스크톱 앱 — 재학습 커리큘럼 2주차

[![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=flat-square&logo=c-sharp)]()
[![SQLite](https://img.shields.io/badge/SQLite-3-003B57?style=flat-square&logo=sqlite)](https://www.sqlite.org/)
<!-- [![Status](https://img.shields.io/badge/Status-Complete-059669?style=flat-square)]() -->

---


## 📌 프로젝트 개요

3-Tier 구조(UI / Business Layer / Data Access Layer)를 직접 설계하고,
**WinForms + ADO.NET + SQLite** 조합으로 동작하는 메모 관리 앱을 구현했습니다.
CRUD 전체 흐름과 비동기 UI 처리를 실무에 가까운 방식으로 복습했습니다.

---

## 🖥️ 스크린샷

<!-- 실행 화면 캡처 후 아래에 추가하세요 -->
```
[스크린샷을 여기에 추가하세요]
예시: ![메인 화면](./screenshots/main.png)
```

> **실행 예시**
> - 메모 목록이 DataGridView에 표시
> - 제목/내용 입력 후 저장 버튼 클릭 시 DB에 즉시 반영
> - 선택 항목 수정 및 삭제 가능

---

## 🗂️ 파일 구조
<!-- 
```
week2-winforms-crud/
├── UI/
│   ├── MainForm.cs            # 메인 폼 (이벤트 핸들러)
│   └── MainForm.Designer.cs   # 폼 디자이너 자동 생성 파일
├── BL/
│   └── NoteService.cs         # 비즈니스 로직 (유효성 검사 등)
├── DAL/
│   ├── NoteRepository.cs      # DB CRUD 메서드
│   └── DatabaseHelper.cs      # SqlConnection 래핑 클래스
├── Models/
│   └── Note.cs                # 데이터 모델
├── schema.sql                 # 테이블 생성 DDL
└── README.md
``` -->

---

## 🛠️ 기술 스택

| 항목 | 내용 |
|------|------|
| 언어 | C# 11.0 |
| 프레임워크 | .NET 8.0 Windows Forms |
| 데이터베이스 | SQLite 3 (Microsoft.Data.Sqlite) |
| 아키텍처 | 3-Tier (UI / BL / DAL) |
| 개발 환경 | Visual Studio 2022 |

---

## ⚙️ 핵심 구현 내용

### 3-Tier 아키텍처

```
MainForm (UI)
    │  이벤트 발생
    ▼
NoteService (BL)       ← 유효성 검사, 비즈니스 규칙
    │  데이터 요청
    ▼
NoteRepository (DAL)   ← SQL 실행, DB 연결
    │
    ▼
SQLite DB
```

---

### CRUD 구현

<!-- | 기능 | 메서드 | HTTP 유사 개념 |
|------|--------|--------------|
| 전체 조회 | `GetAllNotes()` | GET |
| 단건 조회 | `GetNoteById(int id)` | GET /{id} |
| 생성 | `InsertNote(Note note)` | POST |
| 수정 | `UpdateNote(Note note)` | PUT |
| 삭제 | `DeleteNote(int id)` | DELETE | -->

---

<!-- ### 유효성 검사 (NoteService)

```csharp
public bool ValidateNote(Note note)
{
    if (string.IsNullOrWhiteSpace(note.Title))
        throw new ArgumentException("제목을 입력하세요.");
    if (note.Title.Length > 50)
        throw new ArgumentException("제목은 50자 이내로 입력하세요.");
    if (string.IsNullOrWhiteSpace(note.Content))
        throw new ArgumentException("내용을 입력하세요.");
    return true;
}
```

---

### SQL 파라미터 바인딩 (SQL Injection 방지)

```csharp
// ❌ 문자열 직접 삽입 (위험)
$"INSERT INTO Notes VALUES('{title}', '{content}')"

// ✅ 파라미터 바인딩 (안전)
cmd.Parameters.AddWithValue("@title", note.Title);
cmd.Parameters.AddWithValue("@content", note.Content);
```

---

## 🛢️ DB 스키마

```sql
CREATE TABLE IF NOT EXISTS Notes (
    Id      INTEGER PRIMARY KEY AUTOINCREMENT,
    Title   TEXT    NOT NULL,
    Content TEXT    NOT NULL,
    Created TEXT    DEFAULT (datetime('now', 'localtime'))
);
``` -->

---

## ▶️ 실행 방법

```bash
# 저장소 클론
git clone https://github.com/[YOUR_USERNAME]/week2-winforms-crud.git
cd week2-winforms-crud

# NuGet 패키지 복원
dotnet restore

# 빌드 및 실행
dotnet run
```

> **요구 사항**
> - Windows OS (WinForms는 Windows 전용)
> - .NET 8.0 SDK 이상
> - Visual Studio 2022 권장

---

## 💡 트러블슈팅

<!-- 실제 겪은 문제를 작성하세요. 면접 단골 질문입니다. -->
<!-- 
**문제:** DataGridView 업데이트 시 UI가 잠시 멈추는 현상
**원인:** DB 조회를 UI 스레드에서 동기 방식으로 호출
**해결:** `async/await`로 DB 조회 메서드를 비동기 처리, `DataSource` 갱신은 UI 스레드에서 수행 -->

---

## 📅 학습 기간

- 시작일: `2026-03-13`
- 완료일: `2026-MM-DD`

---

## 🔗 관련 링크

- [이전 단계 ← week1-csharp-basics](../week1-csharp-basics)
- [다음 단계 → week3-aspnet-api](../week3-aspnet-api)
- [커리큘럼 전체 보기](../README.md)