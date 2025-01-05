
using UnityEngine;


// 뒤끝 SDK namespace 추가
using BackEnd;

public class BackendManager : MonoBehaviour
{
  
    public void Awake()
    {
       // Update() 메소드의 Backend.AsyncPoll(); 호출을 위해 오브젝트를 파괴하지 않는다.
       DontDestroyOnLoad(gameObject);

       //뒤끝 서버 초기화
       BackendSetup();

    }

   
    
   

    public void BackendSetup()
    {
          //뒤끝 초기화
        

         BackendCustomSetting settings = new BackendCustomSetting();
         settings.clientAppID = "3c876150-ca7e-11ef-a123-b3838084f2199106";
         settings.signatureKey = "3c878860-ca7e-11ef-a123-b3838084f2199106";
         //settings.functionAuthKey = "뒤끝펑션 키";
         //settings.isAllPlatform = true;
         //settings.sendLogReport = true;
         settings.timeOutSec = 100;
         settings.useAsyncPoll = true;
         //settings.autoLocationToAsync = false; 


      

         Backend.InitializeAsync(settings, callback => {
          
           if (callback.IsSuccess())
            {
                Debug.Log("초기화 성공 : " +settings); // 성공일 경우 statusCode 204 Success
            }
            else
            {
                Debug.LogError("초기화 실패 : "+settings); // 실패일 경우 statusCode 400대 에러 발생
            }

        });

    }
}