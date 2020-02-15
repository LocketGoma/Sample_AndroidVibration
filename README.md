# Sample_AndroidVibration
안드로이드 - 유니티에서 사용가능한 커스텀 진동 함수 백업.



사용법 :
1) 해당 파일들을 'Assets/Plugins/Android' 에 삽입.

(다른 메니패스트 파일이 있다면 여기 메니패스트 파일을 사용하지 않고 해당 파일을 수정해도 됨.)

2) 사용 : UnityVibration.cs 파일 참조 ::

  (1) AndroidJavaObject 정의
  
  (2) AndroidJavaObject 선언, 선언시 ("패키지명.클래스명") 으로 태그
  
  (3) 원하는 클래스에서 AndroidJavaObject 변수를 호출.
  
  (4) AJO.Call ("메소드명", 인자) 로 사용.
  
  
참고 자료 :
https://developer.android.com/reference/android/os/Vibrator.html
https://gist.github.com/aVolpe/707c8cf46b1bb8dfb363
