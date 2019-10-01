#pragma strict

import UnityEngine.GameObject;

var turn;
var cycle;
var yourunit : Object[] = new Object[6];
var enemyunit: Object[] = new Object[6];

class Data{
var name : String;
var Life : int;
var Armor : int;
/*
형을 무조건 지정해 줘야한다.
변수형의 지정이 없으면 어떠한 데이터도 넣을수 없다.
매우 중요하니 필수.
*/
}


function Start () {

    var unit = new Data();
    
    unit.name = "User";
    unit.Life = 125;
    unit.Armor = 3;

    var save = JsonUtility.ToJson(unit, true);
    //File.WriteAllText(Application.dataPath+"Assets\\data.json", save);
    Debug.Log(save);
    /*
    var reader = File.ReadAllText(Application.dataPath+"Assets\\data.json");
    var load = reader.FromJson.<Data>(reader);
    
    Debug.Log(reader);
    */
    
    /*
    고쳐야 할것들.
    자체석인 저장과 불러오기는 된다.
    
    하지만, 저장이 파일이 아닌 어떤 인시 바이너리로 저장되어 물리적으로 읽어볼수 없고
    
    불러온다 해도 클레스 배열째로 들고오기 때문에 내용물 확인이 불가능하다.
    현시점에 필요한것은, 이 둘을 자유자제로 활용할수 있게 하는것.
    
    (하나의 클레스를 더 만들어 쓰는 방식이 보편화 되있는 듯 해보이나,
    일단 코드독해 난이도가 심상치 않아보이므로, 몸이 거의 완치된 후에 제확인 해보도록 하자)
    */
}
function Update () {

  
}

/*
앞% %% %%  %%  %%  %뒤
근접/원거리/브루탈/공성/방어지원/공격지원

근접
(공격) 1사이클러, 앞열공격
(방어) 1사이클러, 앞열공격

원거리
(공격) 2사이클러, 렌덤위치.
(방어) 1사이클러, 앞열공격 

브루탈
(공격) 3사이클러, 앞열공격+주요목표 뒷열 피해 75%
(방어) 2사이클러, 앞열공격

공성
(공격) 3사이클러. 렌덤위치, 주목표 앞뒤 1열 피해, 75%
(방어) 4사이클러. 렌덤위치, 주목표 앞뒤 1열 피해, 100%
방어지원
(공격) 5사이클러, 뒷열공격.
(방어) 5사이클러, 뒷열공격.
공격지원
(공격) 2사이클러. 뒷열공격
(방어) 3사이클러. 랜덤위치

1사이클링당의 순서
1. 방어- 원거리
2. 공격- 브루탈
3. 공격- 공성
4. 방어- 브루탈
5. 방어- 공격지원
6. 공격- 원거리
7.방어-공성
8.공격-공격지원
9. 방어-방어지원
10. 공격-근접
11. 방어- 근접
12. 공격- 방어지원
-----------------------------------------------------------------------------
기본전투 모듈.
기본 공격은 사이클링으로 돌아간다.
능력의 사용의 기본은 터닝으로 돌아간다.
모든 터닝이 돌아야지만 사이클링이 한번 돌아가며,
터닝의 기본은 12이다.'
전투의 시작
유닛 확인(아군, 적군)
사이클 확인 0
턴 확인 0
전투 개시
시작 사이클 1
시작 턴 1
능력 사용 우뮤 확인(사이클링, 터닝)
능력행동 사용
능력사용시 턴 종료.
능력 비사용시 공격 가능여부로 패턴 이동.
공격 가능 유무확인(사이클링)
공격 불가시 턴 종료.
공격 행동 실행.
다음 유닛에게 턴넘김
모든 유닛의 턴 사용시 사이클 넘김.
다음 턴 재게
*/


/*
https://forum.unity.com/threads/howto-use-json-in-5-3-guide.373455/ 나중에 읽어 볼만 한 것
*/