
# ERP_인사관리 프로그램 ver.2.0.0.1

Kwon Ahyeong(2021.10.06_update) [![Gmail Badge](https://img.shields.io/badge/Gmail-d14836?style=flat-square&logo=Gmail&logoColor=white&link=mailto:snugyun01@gmail.com)](mailto:dkdud081@gmail.com)



## 개요
```
중복되는 기능들을 .lib로 제작하고 프로그램 단위별 .dll을 제작 한 후 서버에 배포하는 작업을 진행함  

시스템 설계 및 업무분석 : 김태영 교수님
화면 설계 및 구현 : 권아영
```
#### 프로젝트 기간 : 2021.08.30 ~ 2021.10.21  

</br>

## 목차

[Ⅰ) 기술 스택 및 개발 환경](#ⅰ기술-스택-및-개발-환경)

[Ⅱ) 개발 진행](#ⅱ-개발-진행)

[Ⅲ) 주요기능](#ⅲ-주요기능)

[Ⅳ) UI/UX](#ⅳ-uiux)

[Ⅴ) 프로젝트 구현 기술](#ⅴ-프로젝트-구현-기술)




## Ⅰ)기술 스택 및 개발 환경

  

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) ![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)

  

###  사용언어

* C#

* Oracle PL/SQL

### Framework

*  [.NET](https://www.microsoft.com/ko-kr/download/details.aspx?id=30653) - 윈도우 프로그램 개발 및 실행 환경(4.7.2)

### Server

* Oracle 11G

### 기타

-  [Visual Studio 2019](https://visualstudio.microsoft.com/ko/) - 마이크로소프트 통합 개발 환경(IDE)

-  [live chart](https://lvcharts.net/App/examples/v1/WinForms/start) - Open source data visualization for .Net

-  [Report-viewer](https://docs.microsoft.com/ko-kr/sql/reporting-services/application-integration/integrating-reporting-services-using-reportviewer-controls-get-started?view=sql-server-ver15) - .Net Framework 4.6 이상의 모든 버전에서 사용가능

## Ⅱ) 개발 진행

- [x] 코드 관리
- [x] 인사기록관리
- [x] 인사변동관리
- [ ] 업무평가(개발중)
- [x] 증명서 발급
- [x] 현황 및 통계


## Ⅲ) 주요기능

#### C#

>* .dll 사용 
>* 중복기능의 함수화 및 Library 생성
>* 그리드뷰와 컨트롤 바인딩
>* 비밀번호, 주민번호 암호화
>* Delegate 

#### Oracle (PL/SQL)
>* 트리거 사용
>* 저장 프로시저 및 시퀀스 사용
>* 코드 호출 함수 제작 및 활용

[프로젝트 기능 자세히 보기](#ⅴ-프로젝트-구현-기술)

## Ⅳ) UI/UX

### 로그인 화면

![image](https://user-images.githubusercontent.com/50813232/136518350-ef7fcce4-5129-424f-9a41-c196ecbc429f.png)
![image](https://user-images.githubusercontent.com/50813232/136518252-700f2788-5efe-4aa9-8a43-d4c337e33b5d.png)
 ##### [암호화 기능 구현](#주민번호-비밀번호-암호화)
```
- 시스템 실행 하기 전 해당 프로그램 사용이 적합한지와 사원 정보를 얻기 위해 제작
- 로그인 5회 이상 실패를 할 경우 계정이 잠기는 기능 구현하였음
- 아이디 저장 시, config 파일에 입력한 아이디가 저장됨
```

 
### 메인화면

![image](https://user-images.githubusercontent.com/50813232/136518424-008431ca-ed8e-44d5-994d-49a94f6c32dd.png)
##### [공용버튼 기능](#공용-버튼)
```
- 다양한 폼(기능)을 메인을 통해 보여줌
- 공용버튼 : 같은 기능을 시행하는 버튼을 하나로 묶음
- 메뉴(트리뷰) : 기능을 대분류와 소분류로 나누어 트리뷰로 분류
```

***
### 코드 관리 화면

> 모든 코드가 동일한 형식을 취할 때 코드를 그룹화
 일반적인 코드는 코드 그룹화를 시켜줌
 분석 & 통계에 활용(조인할 때 편리함)
 부가적으로 옵션이 붙는 코드는 개별적으로 관리(ex. 부서코드)

#### - 코드 관리

![image](https://user-images.githubusercontent.com/50813232/135438922-35346311-592d-4f2a-9f51-c65de72e4efd.png)

#### - 일반코드 관리

![image](https://user-images.githubusercontent.com/50813232/135439138-228b4a6d-3a66-4b2b-8c3f-1e2f55aa76b3.png)
```
- 검색조건의 그룹코드 콤보박스는 그룹코드 데이터 바인딩을 하여 표현.   
- 그룹코드는 새 창(윈도우)를 띄워 검색하여 사용.   
```

#### - 부서코드 관리

![image](https://user-images.githubusercontent.com/50813232/135439205-cb79aba3-143a-4e7c-8c49-d7c0f5c91234.png)
  
***
### 인사기본사항 화면

</br>

#### - 인사기본정보사항  

![image](https://user-images.githubusercontent.com/50813232/135439315-e8849d86-ed3a-44ba-8f11-b12af6e00ac1.png)

```
- 사원의 개인정보를 입력, 수정 할 수 있음
- 우편번호API 활용하여 주소 및 우편번호 검색
- 인사 정보 신규 생성 시, 로그인 계정 생성 
- 사원 번호 채번을 위한 시퀀스 생성(년도 + 000 + 시퀀스) 
```
[주민번호 암호화 기능](#주민번호-비밀번호-암호화)  
[인사 정보 생성 시, 계정 생성](#트리거-생성)
</br>
[사원번호 채번을 위한 시퀀스 생성](#프로시저-및-시퀀스-사용)
</br>
</br>

#### - 학력사항 

![image](https://user-images.githubusercontent.com/50813232/135439703-a9a4e087-6f3d-4c24-ba4b-7bed0f68d0b4.png)

```
- 가족사항 및 수상경력, 경력사항, 자격면허, 외국어 프로그램과 동일한 패턴으로 제작되어 대표로 하나만 업로드함.   
- 왼쪽의 그리드에 사원 정보를 띄우고 더블클릭으로 선택 시, 오른쪽 그리드에 표현.  
```

#### - 인사기록 통합조회(Read Only)

![image](https://user-images.githubusercontent.com/50813232/135440007-d193b30e-16ea-49ab-8278-93bc3b44a25d.png)
```
- 그리드를 더블클릭 시, 각 컨트롤에 데이터 배치.   
- Adapter 사용으로 Select 속도 높임.
```

</br>

***

### 인사 발령 화면

#### 인사발령 대장 관리
![image](https://user-images.githubusercontent.com/50813232/137824925-2b76c263-b891-46cd-add0-7d885bd514ba.png)
```
- 인사 발령 할 때 사용 될 ‘인사발령번호’ 부여 (인사발령번호는 시퀀스를 활용하여 자동 부여)
- 같은 일자나 같은 내용의 발령 내용을 그룹화
- 인사 발령과 발령 대장의 테이블(DB)를 FK로 묶어서 이상 현상을 막음
```
[인사발령번호 시퀀스 생성](#프로시저-및-시퀀스-사용)

</br>

#### 인사발령 관리
![image](https://user-images.githubusercontent.com/50813232/137824878-d7b1b72f-24c6-476d-b130-e8ba54129228.png)
```
- 보직에 변화가 있는 직원의 인사 이동 내용을 기재
- 발령 이후 인사 기본 정보의 계약사항 정보도 변경
- 로그인 한 사람의 정보로 발령권자의 이름을 자동으로 기입
```

</br>

#### 인사발령 조회
![image](https://user-images.githubusercontent.com/50813232/137825325-bda61585-6227-423e-a83b-9ab40083737e.png)

```
- 인사 발령 정보를 한 눈에 파악할 수 있음
- 사원 번호와 발령 번호 뿐만 아니라 지정 된 날짜 사이에 일어난 발령 내역을 알기 위해 조건에 시행 일자를 추가
- 특정 사원 번호로 검색 할 시, 오른쪽의 표에 사원의 발령 내역이 나타남
```

</br>

#### 업무평가항목 및 기준 관리
![image](https://user-images.githubusercontent.com/50813232/137827515-3e07babf-8be0-4f08-941d-7401c232d4e1.png)
```
- 업무평가를 위한 문항과 각 문항별 점수 관리를 위한 프로그램
- 평가표 유형별로 검색을 할 수 있음(신규 추가 시 콤보박스에 추가됨)
```

</br>

#### 업무평가진행 관리
![image](https://user-images.githubusercontent.com/50813232/137828674-1916ae46-aecc-4a18-ad02-e53ac39f4a05.png)

```
- 업무평가 진행 기간을 따로 관리 해 주는 프로그램
- 추후 업무평가 진행 시, 진행 관리의 데이터 기준으로 진행 할 예정
```

</br>

#### 업무평가진행 관리
![image](https://user-images.githubusercontent.com/50813232/137830692-d8a7091b-aa52-4385-a47f-4e8092ec1e1e.png)
![image](https://user-images.githubusercontent.com/50813232/137830696-99c891c2-c299-407d-9528-4f7172357987.png)

```

- 평가기준 선택과 평가자와 피평가자를 선택하여 업무평가 대상자를 생성
- 여러 명을 선택 할 수 있게 체크박스를 추가함
- 평가 단계와 평가표 유형은 직접 입력 할 수 있게 하였음
```

</br>

#### 업무 평가
![image](https://user-images.githubusercontent.com/50813232/137844439-c20c8bd6-7bb1-45a1-bccc-174951d4e1c5.png)
![image](https://user-images.githubusercontent.com/50813232/137846528-ecde14eb-26e3-46fc-bf0b-8998fa780ed3.png)
```
- 업무평가 실시 프로그램
- 현재 로그인 되어있는 정보를 통해 해당 사원의 평가를 진행해야 할 정보를 보여줌
- 평가 마감일이 임박했거나 지났는데 평가를 하지 않은 내용은 빨간색으로 강조 하였음
- 앞서 그리드에서 평가를 해야할 컬럼(사원)을 더블 클릭하면 평가표가 나타남
- 업무평가 항목 및 기준 관리에 추가하였던 내용 중 평가 유형에 따라 표현
- 평가 항목을 반복문으로 row를 만들어 내고, 라벨을 추가하여 표를 만듦.
- 평점에 해당하는 라벨을 클릭 시, 점수와 점수 합계 표현
```

</br>

#### 업무평가 진행현황
![image](https://user-images.githubusercontent.com/50813232/137859534-4532eb2d-c12b-450d-a9c3-7bffc3ec4691.png)

```
- 진행 중인 업무평가자들의 진행 현황을 볼 수 있음
- 평가가 종료 되었지만 평가를 다 진행 하지 못한 데이터는 빨간색으로 강조를 하였음
- 마지막으로 시행 한 평가 일자를 함께 띄워주어 언제 마지막으로 끝냈는지 알 수 있음
```

</br>

#### 업무평가 진행 현황
![image](https://user-images.githubusercontent.com/50813232/137859966-72b8e627-fa48-4536-9c53-5024308e3a2d.png)

```
- 진행 중인 업무평가자들의 진행 현황을 볼 수 있음
- 평가가 종료 되었지만 평가를 다 진행 하지 못한 데이터는 빨간색으로 강조를 하였음
- 마지막으로 시행 한 평가 일자를 함께 띄워주어 언제 마지막으로 끝냈는지 알 수 있음
```

</br>

#### 업무평가 결과 조회
![image](https://user-images.githubusercontent.com/50813232/137861486-b10825f7-c7af-4533-9ded-51f11b8473e8.png)
![image](https://user-images.githubusercontent.com/50813232/137861506-a4421024-dba8-4f4c-8baa-edf084f63395.png)

```
- 관리자 계정으로 접속하면 모든 정보가 다 뜨는 반면, 다른 계정으로 접속 시, 로그인 된 계정 정보로 평가 결과를 조회할 수 있음
- 자세한 사항은 더블클릭을 하여 확인 할 수 있음
```


***
</br>

### 증명서 발급

![image](https://user-images.githubusercontent.com/50813232/137850786-babf015a-2402-4f0f-ae84-fd64cc7f277a.png)
```
- 증명서 발급은 오른쪽의 입력란에 입력 후 공용 버튼 중 프린터 버튼을 클릭 시 번호 - 발급과 증명서 미리보기 창이 뜸
- 재발급은 발급 내역을 선택하여 재발급 버튼 클릭으로 할 수 있음
- 재발급 시, 발급일 기준 24시간 이내에 가능하며 이후에는 발급 실패 메시지 창이 뜸
- Report-Viewer 을 사용하여 증명서를 제작하였음
```
</br>

국문 증명서(경력 / 재직) </br>

![image](https://user-images.githubusercontent.com/50813232/137850871-38236d70-28e4-4e20-a6cf-5642bacccdf6.png) 
![image](https://user-images.githubusercontent.com/50813232/137850878-f1e830d9-9c44-4083-b7b5-4666c88a7a02.png)  

영문 증명서(재직 / 경력) </br>

![image](https://user-images.githubusercontent.com/50813232/137850892-94b96292-bfe9-48cf-938f-855aeb5072ba.png)
![image](https://user-images.githubusercontent.com/50813232/137850902-ad75c745-25c5-4fcc-9909-bc35c8718429.png)

   
[Report-viewer](https://docs.microsoft.com/ko-kr/sql/reporting-services/application-integration/integrating-reporting-services-using-reportviewer-controls-get-started?view=sql-server-ver15) 활용

</br>

***

</br>

### 인원 현황 및 추이

#### 부서, 직급별 인원 현황
![image](https://user-images.githubusercontent.com/50813232/137864959-0a6c5c89-f916-41e0-b8fd-8b63b6299567.png)
![image](https://user-images.githubusercontent.com/50813232/137865758-86156fb0-6452-4a96-ad68-3922cd8923bd.png)

```
* 2021.10.19 기준 부서, 직급별 인원 현황

- 조회 날짜를 기준으로 재직 중인 사원들의 부서 혹은 직급별 인원수를 나타냄
- 정확한 숫자를 보기 위한 그리드와 한 눈에 보기 위한 그래프 두 가지로 표현
- 남자 비율과 여자 비율 그리고 총 합계를 마지막 row에 추가함
- 같은 방식으로 제작하였음
```

</br>

#### 재직 인원 추이
![image](https://user-images.githubusercontent.com/50813232/137866655-e4902217-e078-44d0-ac57-1f7315d6fc52.png)

```
* 2020.01 부터 2021.10 까지 월별 추이

- 조회 기간을 정하여 그 기간 동안의 재직 인원 추이를 나타냄
- 입 · 퇴사 인원을 추가로 나타내어 그래프를 풍성하게 만듦
```

</br>

#### 입사 · 사직 인원 추이
![image](https://user-images.githubusercontent.com/50813232/138003674-a8000a62-4963-45d2-9b50-74e062e99eec.png)
![image](https://user-images.githubusercontent.com/50813232/138003680-060a327a-fcb4-496b-b149-f7a574d2f620.png)

```
- 조회 기간을 정하여 그 기간 동안의 입사 인원 추이를 나타냄
- 우측의 라디오버튼의 체크 된 특성에 따라 특정 기간 동안의 월별 인원수 혹은 년도 별 인원수로 나타냄
- Null 값으로 나타나는 값을 0 으로 표현
```

</br>

***
 
 </br>

### 코드 관리

#### 그룹, 일반코드 관리
![image](https://user-images.githubusercontent.com/50813232/138004088-120f0639-ad26-427e-9f45-e832442bc21e.png)
   
![image](https://user-images.githubusercontent.com/50813232/138004133-20a776b7-9d21-44c4-a387-b94854fc497b.png)

```
- 모든 코드가 동일한 형식을 취할 때 코드를 그룹화
- 일반적인 코드는 코드 그룹화를 시킴
- 분석 & 통계에 활용(조인할 때 편리함)
```

#### 부서코드 관리
![image](https://user-images.githubusercontent.com/50813232/138004224-0c3934ae-2240-4c74-8527-d1da7e173583.png)

```
- 부가적으로 이것저것 붙는 코드인 부서 코드는 개별적으로 관리
- 개별 코드로 만들 시 조인과 함수화가 단순해짐
```

### 공용 코드 검색 폼
![image](https://user-images.githubusercontent.com/50813232/138004284-72011455-69d3-4b84-a926-9b19b13a91ee.png)
![image](https://user-images.githubusercontent.com/50813232/138004293-6d78c9c9-2fa0-4d4b-84b0-1c6df90ad312.png)

```
- 공통적으로 검색되는 코드들을 따로 뽑아 form 을 제작함
- 한 개의 데이터만 가져오는 창과 여러 개의 데이터를 가져올 수 있는 창을 각각 제작함
- 따로 폼을 만들지 않아도 되는 이점이 있음
```

</br>

***

</br>

## Ⅴ) 프로젝트 구현 기술

#### 주민번호, 비밀번호 암호화
* 주민번호 : 양방향 암호화(AES128)_실제 DB에 저장된 주민번호 모습

![image](https://user-images.githubusercontent.com/50813232/135437113-a8e82a6e-6261-4af0-a2ac-2e2cd31087bb.png)

* 비밀번호 : 일방향(SHA512)암호화

![image](https://user-images.githubusercontent.com/50813232/135438275-6551a4a8-b118-4f59-9720-272cfdc96d52.png)

</br>

*** 
</br>

#### 공용 버튼
* 각 폼 별로 사용한 버튼이 다른데, 이를 1과 9의 배열을 통해 간편하게 버튼 활성화 컨트롤을 할 수 있음.
	1.  자주 사용되는 버튼을 위주로 명명하였음.
	2.  직접 배열을 지정하여 설정 할 수 있는 함수 설정.   

```C#
last_button_status = Utility.SetFuncBtn(MainBtn, "1"); 

static public string SetFuncBtn(Button[] btn, string func)
        {
            if (btn.Length == 0) return "";
            string wk_func = "0000000";

            if (func.Equals("0")) wk_func = "1000000";   //---조회 Only 버튼 상태                      
            if (func.Equals("E")) wk_func = "0000000";   //---Only 종료 버튼 상태
            if (func.Equals("P")) wk_func = "1000001";   //---조회 후 인쇄/엑셀 가능 상태
            if (func.Equals("1")) wk_func = "1100000";   //---기본 상태
            if (func.Equals("2")) wk_func = "1101001";   //---조회 후
            if (func.Equals("3")) wk_func = "0101110";   //---수정 및 추가 후
            if (func.Equals("4")) wk_func = "1000110";   //---조회 후 수정 발생(추가는 없음)
            if (func.Equals("EX1")) wk_func = "0000000"; //---엑셀 Import 前

            SetFuncBtn2(btn, wk_func);
            return wk_func;
        }
static public string SetFuncBtn2(Button[] btn, string func)
        {
            if (btn.Length == 0) return "";
            if (string.IsNullOrEmpty(func)) return "";
            if (func.Length != 7) return "";
            
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(func);
            for (int i = 0; i < bytes.Length; i++)
            {
                btn[i].Enabled = bytes[i] == '1' ? true : false;
            }
            return func;
        }
```
</br>

*** 
</br>

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

***
</br>

#### 프로시저 및 시퀀스 사용
* 채번을 하기위한 시퀀스 생성 
* 시퀀스 리턴을 위한 프로시저 사용(예제코드)
```sql
create or replace PROCEDURE SP_UCSUB025 

(
  P_EMPNO IN VARCHAR2 
, P_KIND IN VARCHAR2 
, P_DATE IN VARCHAR2 
, P_LANG IN VARCHAR2 
, P_CNT IN VARCHAR2 
, P_SAU IN VARCHAR2 
, O_CERI_NUM OUT VARCHAR2 
)
IS
      vn_cnt VARCHAR2(20);
      vn_cur_datec date := sysdate;
BEGIN 

    vn_cnt := TO_CHAR(SYSDATE, 'YYYYMM')||'-'||SUBSTR(SEQ_NAME.NEXTVAL + 1000 , -3) ;
    
    -- INSERT 쿼리문 실행
    INSERT INTO kay_insa_cerl(  CERI_EMPNO
                                ,CERI_KIND
                                ,CERI_DATE
                                ,CERI_LANG
                                ,CERI_NUM
                                ,CERI_CNT
                                ,CERI_SAU ) 
                       VALUES( P_CERI_EMPNO
                              ,P_CERI_KIND
                              ,P_CERI_DATE
                              ,P_CERI_LANG
                              ,vn_cnt
                              ,P_CERI_CNT
                              ,P_CERI_SAU);
   
   -- OUT PARAMETER 설정
    O_CERI_NUM := vn_cnt;
   commit;
  
END SP_UCSUB025;
```

</br>

*** 

#### Delegate 활용

* 증명서 발급 종류에 따른 증명서 폼을 띄울 때, 파라미터들을 넘기기 위해 사용.    
* 부모폼의 파라미터들을 자식폼으로 DataSendEvent를 통해 넘겨줌.   
* 증명서 발급 대장에서 넘긴 파라미터들을 받아옴.    
* DataSendEvent에서 호출 한 SetActiveValue함수로 파라미터를 받음.   


```C#
//*-- 부모폼
public delegate void DataPushEventHandler(string _value, string _value2, string _value3);

public partial class Main : Form
{ 
    public DataPushEventHandler DataSendEvent;
    private string value { get; set; } //---value 값 
    private string value2 { get; set; } //---value2 값
    private string value3 { get; set; } //---value3 값 
    //...

    //--- 증명서에 데이터 넘기는 함수
    void func_sendData()
    {
        //--- 자식 폼 띄우는 명령어
        Form2 frm2 = new Form2();
        this.DataSendEvent += new DataPushEventHandler(frm2.SetActiveValue);
        DataSendEvent(value, value2, value3);
        frm2.ShowDialog();
    }

    //...
}
```

``` C#
//*-- 자식폼

//******************************
// 파라미터 받아오는 함수
//******************************
public void SetActiveValue(string _value, string _value2, string value3)
{
    Value1 = _value;
    Value2 = _value2;
    Value3 = _value3;
}

//...

private string Value{ get; set; }  
private string Value2 { get; set; }
private string Value3 { get; set; }

```

</br>

#### 우편번호 API
</br>

- 따로 우편번호, 주소 DB를 만들면 DB 용량을 많이 차지하고, 업데이트가 늦어 이를 보완하기위해 행정안전부 API를 사용 </br>
- 사용할 정보인 도로명주소와 우편번호 데이터만 뽑아내어 사용 </br>

![image](https://user-images.githubusercontent.com/50813232/138029973-d9a4175d-75f2-4380-90b6-5fbed13d1f7c.png)

***

</br>

#### Report-Viewer 

- 증명서제작을 하기 위해 사용한 라이브러리 </br>
- 데이터 세트는 ViewModle(get,set) 에서 받아옴 </br>
- 파라미터를 받아와 우측의 리포트에 입력 </br>
- 입력하는 값만큼 행이 늘어나는 테이블을 사용 </br>

![image](https://user-images.githubusercontent.com/50813232/138043306-676c0989-16ef-4112-b10e-08e1125ce4d9.png)






[//]: #  (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

  

[dill]: <https://github.com/AhyeongPortfolio/KayMain>

[git-repo-url]: <https://github.com/joemccann/dillinger.git>