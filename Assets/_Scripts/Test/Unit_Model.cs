using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit_Model : MonoBehaviour {

    //猪
    public class Pig
    {
        public int life;
        public int attack;
        public int speed;
        public Sprite img;

        public Pig(int life,int attack,int speed,Sprite img)
        {
            this.speed = speed;
            this.attack = attack;
            this.life = life;
            this.img = img;
        }
    }
    public static List<Pig> pigs;
    Sprite[] pigs_imgs;
    int pigs_count = 5;

    //发射台
    public class Shooter
    {
        public int rotateSpeed;
        public int power;
        public Sprite img;

        public Shooter(int rotateSpeed,int power,Sprite img)
        {
            this.rotateSpeed = rotateSpeed;
            this.power = power;
            this.img = img;
        }
    }
    public static Shooter shooter;
    Sprite sht_img;



    // Use this for initialization
    void Awake () {
        pigs = new List<Pig>();
        pigs_imgs = new Sprite[pigs_count];
        for(int i = 1; i <= pigs_count; i++)
        {
            string name = i < 10 ? "0" + i.ToString() : i.ToString();
            pigs_imgs[i - 1] = Resources.Load(name, typeof(Sprite)) as Sprite;
            pigs.Add(new Pig(100, 10, 50, pigs_imgs[i - 1]));
        }

        sht_img = Resources.Load("10", typeof(Sprite)) as Sprite;
        shooter = new Shooter(10, 20, sht_img);
	}
	
}
