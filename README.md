# BlueArchiveRandomChooser

소스코드가 원인모를 이유로 실행이 안되는 현상이 발생하고 있습니다

원본 파일도 컴퓨터에서 찾을수 없습니다


DataBase 수정 관련은 DataBase에 내용을 추가하는법.txt 와 예시 파일.txt를 확인하세요

앱 파일들은 반드시 BlueArchiveRandomChooser 폴더 안에 위치해야합니다

사용,코드 수정,제배포,상업적 이용 전부 상관 없는데,
제배포, 상업적 이용시에는 저한테 말해주시기만 하면 해도 됩니다

방송에서 사용하는건 말 굳이 안해도 됩니다

DataBase파일들을 수정할떄는 visualstudio 나 visualstudiocode나 notepad++을 이용하는걸 추천드립니다

혹시 문제가 발생하거나, 물어보고싶은게 있을떄는

@lysrhythmgamer - X (구 트위터)

노란딱지#7701 - Discord

로 연락해주시면 답변해드리겠습니다.

======

# DataBase에 요소를 추가하는법
이 문서에서는 DataBase에 요소를 추가하는법을 다루고 있습니다.


문단 1: DataBase종류
DataBase에는 4가지의 종류가 있습니다
각각 Students, Skills, Schools, Equipments로, 이들은 각각

학생들의 이름(StudentsDataBase.txt)

학원들의 이름(SchoolsDataBase.txt)

스킬 슬롯의 이름(SkillsDataBase.txt)

장비 슬롯의 이름(EquipmentsDataBase.txt)

를 저장하고 있습니다

2: DataBase에 요소를 추가하는법

DataBase에 요소를 추가하는법은 다음과 같습니다

(추가하는법)

1 : 추가하려는 요소와 같은 종류의 요소들이 저장되있는 DataBase.txt파일을 찾는다

2 : 해당하는 DataBase.txt파일을 열고, 가장 마지막줄로 갑니다.

(선택)3 : 마지막줄에 작성되있는 요소가 5개인지를 확인합니다.

	=> 이것은 추후에 데이터를 추가할때 가독성을 향상하기 위한것이므로, 굳이 따르지 않아도 작동에는 상관이 없습니다.

4 : 마지막 요소가 적혀져있는 다음에 띄어쓰기가 작성되있다면, 그 띄워쓰기를 지운다음, 다시 띄워쓰기를 한 다음에
	// 슬레시 두개를 작성해주세요.
 
	슬레시는 정확하게 2개여야됩니다.
 
	이것을 지키지 않을경우 코드 작동시에 오류가 발생할수 있습니다.

	예시: 요소 1 // 요소 2 // 요소 3 // 요소 4

	마지막 요소 뒤에는 // 를 붙이면 안됩니다.
	
5 : 파일을 저장하고 닫습니다.

(StudentDataBase인 경우)

이 항목은 StudentDataBase의 작성 및 수정시의 가독성을 향상하기 위해 작성되었습니다.

문법만 정확하게 지켜준다면, 위의 방법을 따라도 상관이 없습니다.

이 항목에서는 작성방법이 아닌, 작성 가이드를 작성하였습니다

1 : 추가하려는 학생의 학원을 확인합니다.

2 : 추가하려는 학생이 이격인지 아닌지를 확인합니다.

3 : StudentDataBase.txt파일을 엽니다

4 : 추가하려는 학생이 소속된 학원의 학생들이 모여있는 구역을 찾습니다.

5-1 : 만약에 추가하려는 학생이 일반 신규 캐릭터라면, 일반캐릭터 뒤, 이격캐릭터 앞의 공간에 작성합니다.

5-2 : 만약에 추가하려는 학생이 이격 신규 캐릭터라면, 이격캐릭터 맨 뒤에 추가합니다


예시 : 이격캐릭터가 아닌경우
 
	일반1 // 일반2 // 일반 3 // 추가한 일반 학생 // 이격 학생

예시 2 : 이격캐릭터인경우
	
	이격 1 // 이격2 // 이격3 // 이격 4 // 신규 이격


문단 2: 기타 가이드

만약, 요소가 5개가 넘어 다음 줄로 넘겼다면, 만약 띄워쓰기가 안되있다면, 띄워쓰기를 한 다음 요소를 작성해주세요

확인법: 키보드의 화살표 왼쪽키를 눌러서 위의 줄로 넘어간다면 띄워쓰기가 안되있는것.


