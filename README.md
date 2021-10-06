
# ERP_인사관리 프로그램 ver.2.0.0.1

Kwon Ahyeong(2021.09.30_update) [![Gmail Badge](https://img.shields.io/badge/Gmail-d14836?style=flat-square&logo=Gmail&logoColor=white&link=mailto:snugyun01@gmail.com)](mailto:dkdud081@gmail.com)

## 개요

ver.2에서는 중복되는 기능들을 .lib로 제작하고

프로그램 단위별 .dll을 제작 한 후 서버에 배포하는 작업을 진행함

  

## 목차

[Ⅰ) 기술 스택 및 개발 환경](#ⅰ기술-스택-및-개발-환경)

[Ⅱ) 개발 일정](#ⅱ-개발-일정)

[Ⅲ) 주요기능](#ⅲ-주요기능)

[Ⅳ) UI/UX](#ⅳ-uiux)

[Ⅴ) 프로젝트 구현 기술](#ⅴ--프로젝트-구현--기술)

Ⅵ)

  

## Ⅰ)기술 스택 및 개발 환경

  

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)

  

###  사용언어

* C#

* Oracle PL/SQL

### Framework

*  [.NET](https://www.microsoft.com/ko-kr/download/details.aspx?id=30653) - 윈도우 프로그램 개발 및 실행 환경(4.7.2)

### Server

* Oracle

### -기타

-  [Visual Studio](https://visualstudio.microsoft.com/ko/) - 마이크로소프트 통합 개발 환경(IDE)

-  [live chart](https://lvcharts.net/App/examples/v1/WinForms/start) - Open source data visualization for .Net

-  [Report-viewer](https://docs.microsoft.com/ko-kr/sql/reporting-services/application-integration/integrating-reporting-services-using-reportviewer-controls-get-started?view=sql-server-ver15) - .Net Framework 4.6 이상의 모든 버전에서 사용가능

## Ⅱ) 개발 일정

> 2021.08.30 ~ 2021.10.21 

| 개발 내용 / 일정(주차)| 1 | 2 | 3 | 4 | 5 | 7 | 8
|--|--|--|--|--|--|--|--|--|--|--|--|
| 화면설계| 0 | 0 | 0 |
| 기능설계 |  |  | 0 | 0 |  |  | 
| 기능 구현 |  |  |  | 0 | 0 | 0 |
| 테스트/구현 |  |  | 0 |  |  |  | 0 | 

## Ⅲ) 주요기능

#### C#

>* .dll 사용 
>* 중복기능의 함수화 및 Library 생성
>* 그리드뷰와 컨트롤 바인딩
>* 

#### Oracle (PL/SQL)
>* 트리거 사용
>* 저장 프로시저 사용
>* 코드 호출 함수 제작 및 활용
>* 

## Ⅳ) UI/UX

### 로그인 화면

> 로그인을 5회 이상 실패를 할 경우 계정이 잠기는 기능 구현하였음
 아이디 저장 시, config 파일에 입력한 아이디가 저장됨
 [암호화 기능 구현](#주민번호-비밀번호-암호화)
 
![image](https://user-images.githubusercontent.com/50813232/135425669-5d6c39fb-8e2a-4fd2-9002-c6faa08d6a3a.png)

### 메인화면

![image](https://user-images.githubusercontent.com/50813232/135425969-0deaf54d-79d5-41c3-b579-8a80fa466845.png)
***
### 코드 관리 화면

> 모든 코드가 동일한 형식을 취할 때 코드를 그룹화
 일반적인 코드는 코드 그룹화를 시켜줌
 분석 & 통계에 활용(조인할 때 편리함)
 부가적으로 옵션이 붙는 코드는 개별적으로 관리(ex. 부서코드)

* 코드 관리

![image](https://user-images.githubusercontent.com/50813232/135438922-35346311-592d-4f2a-9f51-c65de72e4efd.png)

- 일반코드 관리
> 검색조건의 그룹코드 콤보박스는 그룹코드 데이터 바인딩을 하여 표현.
> 그룹코드는 새 창(윈도우)를 띄워 검색하여 사용.

![image](https://user-images.githubusercontent.com/50813232/135439138-228b4a6d-3a66-4b2b-8c3f-1e2f55aa76b3.png)

- 부서코드 관리

![image](https://user-images.githubusercontent.com/50813232/135439205-cb79aba3-143a-4e7c-8c49-d7c0f5c91234.png)

  

### 인사기본사항 화면

- 인사기본정보사항

> [주민번호 암호화 기능](#주민번호-비밀번호-암호화)
[인사 정보 생성 시, 계정 생성](#트리거-생성)

![image](https://user-images.githubusercontent.com/50813232/135439315-e8849d86-ed3a-44ba-8f11-b12af6e00ac1.png)

  
  

- 학력사항

> 가족사항 및 수상경력, 경력사항, 자격면허, 외국어 프로그램과 동일한 패턴으로 제작되어 대표로 하나만 업로드함.
왼쪽의 그리드에 사원 정보를 띄우고 더블클릭으로 선택 시, 오른쪽 그리드에 표현.

![image](https://user-images.githubusercontent.com/50813232/135439703-a9a4e087-6f3d-4c24-ba4b-7bed0f68d0b4.png)

- 인사기록 통합조회(Read Only)
> 그리드를 더블클릭 시, 각 컨트롤에 데이터 배치.
Adapter 사용으로 Select 속도 높임.

![image](https://user-images.githubusercontent.com/50813232/135440007-d193b30e-16ea-49ab-8278-93bc3b44a25d.png)

  

## Ⅴ) 프로젝트 구현 기술

#### 주민번호, 비밀번호 암호화
* 주민번호 : 양방향 암호화(AES126)_실제 DB에 저장된 주민번호 모습

![image](https://user-images.githubusercontent.com/50813232/135437113-a8e82a6e-6261-4af0-a2ac-2e2cd31087bb.png)

* 비밀번호 : 일방향(SHA526)암호화

![image](https://user-images.githubusercontent.com/50813232/135438275-6551a4a8-b118-4f59-9720-272cfdc96d52.png)

#### 트리거 생성

* 신규추가 할 때, 계정 생성하는 트리거 (예제 코드)

```sql
create  or  replace TRIGGER TRI_Name
AFTER  INSERT  ON TableName1
FOR EACH ROW
BEGIN
	INSERT  INTO TableName2(USER_ID,USER_NAME,USER_PSWD,USER_TYPE,USER_PSWD_DAT,USER_EMAIL) 
	VALUES (:new.TableName1_id,:new.tablename1_name,:new.tablename1_bth,'4',sysdate,:new.tablename1_email);
commit;
END;
```

  
  

[//]: #  (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

  

[dill]: <https://github.com/AhyeongPortfolio/KayMain>

[git-repo-url]: <https://github.com/joemccann/dillinger.git>