using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CodeCap : MonoBehaviour
{
    public Text text;
    public Text score1;
    public Text white1;
    public Image sprite;
    public Sprite weak;
    public Sprite petty; 
    public Sprite notorious;
    public Sprite savage;
    public Sprite boss;
    public GameObject modifyimage;
    public GameObject modifyfalse;
    public Text red1;
    public Text final;
    public GameObject firstmodify;
    public GameObject thirdmodify;
    public GameObject fourthmodify;
    GameObject[] objects=new GameObject[5];
    public GameObject secondmodify;
    public GameObject defaultmodify;
    public GameObject coins; 
    public GameObject coins1; 
    public GameObject coins2; 
    public GameObject firstx1;
    public GameObject last1;
    public GameObject cube;
    public GameObject restart;
    public GameObject slider;
    //public GameObject sec;
    public int initializer=0;
    public int initializerx=0;
    public static int scorex;
    public int scorey;
    public int score=10;
    public bool trans=false;
    public GameObject UI;
    public AudioClip audioPos;
    public AudioClip audioNeg;
    public AudioClip audioPosGate;
    public AudioClip audioLevel;
    public AudioClip audioRetry;
    public AudioSource audio;
    public AudioSource audiox;
    public GameObject Level;
    public GameObject Bar;
    public GameObject five;
    public GameObject minusfive;
    public GameObject white;
    public GameObject red;
    public bool ani=true;
    public text1 an;
    public resume resume;
    public Animator animator;
    public Animator isopen;
    public Animator isopen1;
    public bool ismove=true;
    public GameObject bodyguard;
    public GameObject bodyguard1;
    public Animator animatorx;
    public Animator animator2;
    public Animator weak1;
    public Animator door1;
    public Animator door2;
    int minus5=0;
    int five5=0;
    
    
    public Animator lastmodify;

    public pause play;
    public Text scorez;
    
    GameObject s;
  
    public bar bar;
   
    
    void Awake()
    {
          Bar.SetActive(true);
          //  bar.fill.color=bar.grad.Evaluate(1f);

    }
    void Start()
    {
          audio=GetComponent<AudioSource>();
          audiox=GetComponent<AudioSource>();
         
          objects[0]=defaultmodify;
          objects[1]=firstmodify;
          objects[2]=secondmodify; 
          objects[3]=thirdmodify;
          objects[4]=fourthmodify;
          scorex=10;
          ismove=true;
          
          if(score!=0)
          {
            UI.SetActive(true);
            text.text = score.ToString();
            ani=true;
             
            
          }
          
         
    }
    void modifier(int i)
    {
          objects[0]=defaultmodify;
          objects[1]=firstmodify;
          objects[2]=secondmodify; 
          objects[3]=thirdmodify;
          objects[4]=fourthmodify;
      if(i==4)
      {
        bodyguard.SetActive(true);
        bodyguard1.SetActive(true);
      }
      else
      {
        bodyguard.SetActive(false);
        bodyguard1.SetActive(false);
      }
      
      foreach(GameObject obj in objects)
      {
         obj.SetActive(false);
         //Debug.Log(objects[j]);
      }
      objects[i].SetActive(true);
    }
  
    void Update()
    {
            
          
         scorey=scorex;
         bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
         if(score>=40)
         coins1.SetActive(true);
         if(initializer==0)
         {
           text.text="Let's Begin";
            

         }
          if(five5>0)
         {
            five.SetActive(true);
            coins.SetActive(true);

            //red.SetActive(true);
            text.text = score.ToString();
            
            ani=true;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
         }
          if(minus5>0)
         {
            minusfive.SetActive(true);
            coins2.SetActive(true);
            

            //red.SetActive(true);
            text.text = score.ToString();
            
            ani=true;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
         }
          if(initializer>0)
          {
           // UI.SetActive(true);
            white.SetActive(true);
            coins.SetActive(true);

            //red.SetActive(true);
            text.text = score.ToString();
            
            ani=true;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
                  
          }
          if(initializerx>0)
            {
            red.SetActive(true);
            coins2.SetActive(true);
          
            text.text = score.ToString();
            
            ani=true;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
                  
            }
       
            score1.text = scorex.ToString();
            //animatorx.SetBool("coin",false);
          
             
           if(score>=40 )
           {
             modifyfalse.SetActive(false);
            // weak1.SetBool("create",true);
             modifyimage.SetActive(true);
             
           }
           
           else
           {
             modifyfalse.SetActive(true);
            // weak1.SetBool("create",false);
             modifyimage.SetActive(false);
           }
           
      
          
           
       
    }
    public void Defeat()
    {
            animator.SetBool("defeat",true);

    }
 void OnTriggerEnter(Collider other)
 {
   if (other.gameObject.tag == "ll2")
      {
            Destroy(other.gameObject);
            five.SetActive(false);
            coins.SetActive(false);
            
            five5++;
            score+=5;
            scorex+=5;
            bar.slider.value=score;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
            animatorx.SetBool("coin",true);

      }
       if(other.gameObject.tag=="app")
        {
            //white1.text="+5";
            audio.PlayOneShot(audioPos,0.7f);
            white.SetActive(false);
            coins.SetActive(false);
            initializer++;
            Destroy(other.gameObject);
            score+=2;
            scorex+=1;
            bar.slider.value=score;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
            animatorx.SetBool("coin",true);  
        }
      if (other.gameObject.tag == "l1")
      {
            Destroy(other.gameObject);
            minusfive.SetActive(false);
            coins2.SetActive(false);
            minus5++;
            score-=5;
            audio.PlayOneShot(audioNeg,0.7f);
            bar.slider.value=score;
            animatorx.SetBool("coin",false);

      }
 
    //void OnotherEnter(other other)
    //{
          if(score>=40 && score<43)
          {
            
            audio.PlayOneShot(audioPosGate,1f);
            coins1.SetActive(false);

          }
           if(score>=80 && score<83)
          {
            modifyimage.SetActive(false);
            audio.PlayOneShot(audioPosGate,1f);
            coins1.SetActive(false);
          }
           if(score>=120 && score<123)
          {
            audio.PlayOneShot(audioPosGate,1f);
            modifyimage.SetActive(false);
            coins1.SetActive(false);
          }
           if(score>=160 && score<163)
          {
            audio.PlayOneShot(audioPosGate,1f);
            modifyimage.SetActive(false);
            coins1.SetActive(false);
          }
          if(score==200 && score<203)
          {
           
            audio.PlayOneShot(audioPosGate,1f);
            coins1.SetActive(false);
          }
           
        if(score<40)
          {
            sprite.sprite=weak;
            modifier(0);
            animator.SetBool("mode",false);
            animator.SetBool("2nd mode",false);
            animator.SetBool("3rd mode",false);
            animator.SetBool("4th mode",false);
          }
           if(score>=40 && score<80)
          {
            sprite.sprite=petty;
            modifier(1);
            animator.SetBool("mode",true);
            animator.SetBool("2nd mode",false);
            animator.SetBool("3rd mode",false);
            animator.SetBool("4th mode",false);
            
          }
           if(score>=80 && score<120)
          {
            sprite.sprite=savage;
            modifier(2);
            animator.SetBool("2nd mode",true);
            animator.SetBool("3rd mode",false);
            animator.SetBool("4th mode",false);
            

          }
           if(score>=120 && score<160)
          {
            modifier(3);
            sprite.sprite=notorious;
            animator.SetBool("3rd mode",true);
            animator.SetBool("4th mode",false);

          }
            if(score>=160 && score<=200 || score>200)
          {
            sprite.sprite=boss;
            modifier(4);
            animator.SetBool("4th mode",true); 
          }
     
         if(other.gameObject.tag=="ll2")
        {
            //white1.text="+5";
            five.SetActive(false);
            audio.PlayOneShot(audioPosGate,.7f);
            coins.SetActive(false);
            five5++;
            Destroy(other.gameObject);
            score+=5;
            scorex+=5;
            bar.slider.value=score;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
            animatorx.SetBool("coin",true);
            
             
        }
         if(other.gameObject.tag=="l1")
        {
            //white1.text="+5";
            minusfive.SetActive(false);
            coins2.SetActive(false);
           
            minus5++;
            Destroy(other.gameObject);
            score-=5;
            
            bar.slider.value=score;
            bar.fill.color=bar.grad.Evaluate(bar.slider.normalizedValue);
            animatorx.SetBool("coin",true);
            
             
        }
          if(other.gameObject.tag=="Cap1")
        {
            animatorx.SetBool("coin",false);
            audio.PlayOneShot(audioNeg,0.7f);
            
           // red1.text="-2";
            coins2.SetActive(false);
            red.SetActive(false);
            initializerx++;
            Destroy(other.gameObject);
            score-=1;
            //scorex-=10;
            bar.slider.value=score;
         
            
        }
          if(other.gameObject.tag=="barier" && score>=50)
        {
             
            isopen.SetBool("isopen",true);
            isopen1.SetBool("isopen1",true);
            Destroy(other.gameObject);
            ismove=true;
            //lastmodify.SetBool("mode2",true);
             
        }
         if(other.gameObject.tag=="barier" && score<50)
        {
             
            Destroy(other.gameObject);
            ismove=false;
            audiox.Play();
            final.text= scorex.ToString();
            Level.SetActive(true);
            gameObject.SetActive(false);
             
        }
         if(other.gameObject.tag=="barier1" && score<170)
        {
            
            isopen.SetBool("isopen",true);
            isopen1.SetBool("isopen1",true);
            Debug.Log("detect");
            Destroy(other.gameObject);
            audiox.Play();
            ismove=false;
            final.text= scorex.ToString();
            Level.SetActive(true);
            gameObject.SetActive(false);
            
            animator.SetBool("mode",false);
            animator2.SetBool("2nd mode",false);
            animator2.SetBool("3rd mode",false);
            animator2.SetBool("4th mode",false);
         

            Destroy(cube); 
        }   
          else if(other.gameObject.tag=="barier1" && score>=170)
        {
            
            
            isopen.SetBool("isopen",true);
            audiox.Play();
            isopen1.SetBool("isopen1",true);
            Destroy(other.gameObject);
            door1.SetBool("isopen",true);
            door2.SetBool("isopen",true);
        
            ismove=false;
            final.text= scorex.ToString();
            Level.SetActive(true);
          
            lastmodify.SetBool("mode2",true);
            
            Destroy(cube); 
        } 
         
           int s=0;
          if(score!=0)
          {
            UI.SetActive(true);
            
            text.text = score.ToString();
            ani=true;
             
          }
          
         
           if(score<=0)
          { 
            play.ispaused=true;
             
           // PlayerPrefs.SetInt("Coins",scorex);
            restart.SetActive(true);
            
            animator.SetBool("defeat",true);
            audio.PlayOneShot(audioRetry,0.7f);
            
            ismove=false;
            scorez.text=CodeCap.scorex.ToString();
            
          }
          else
            animator.SetBool("defeat",false);
          
         
 }
 void OnCollisionEnter(Collision other)
 {}
   
    void end()
    {
         

    }
    
}
