using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberImg : MonoBehaviour
{
    private static Sprite[] numberSides;
    private static SpriteRenderer rendNembers;
    public static bool show = false;
    public static int sidenmbr;
    public static bool autonum1=false;
    // Start is called before the first frame update
    void Start()
    {
        rendNembers = GetComponent<SpriteRenderer>();
        numberSides = Resources.LoadAll<Sprite>("imageNumbers/");
        hideimg();
    }

    // Update is called once per frame
    void Update()
    {
        if (show == false) hideimg();
        if(autonum1)
        {
            autonum1=false;
            OnMouseDown();
        }
    }
    public static void setimg(int side)
    {
        if(side==10)
        {
            rendNembers.sprite = numberSides[1];
            sidenmbr = side;
        }
        else if(side==20)
        {
            rendNembers.sprite = numberSides[3];
            sidenmbr = side;
        }
        else if(side==1)
        {
            rendNembers.sprite = numberSides[side-1];
            sidenmbr = side;
        }
        else if(side==2)
        {
            rendNembers.sprite = numberSides[side];
            sidenmbr = side;
        }
        else 
        {
            rendNembers.sprite = numberSides[side+1];
            sidenmbr = side;
        }
    }
    public static void hideimg()
    {
        rendNembers.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("baground");
    }
    public static void showimg()
    {
        rendNembers.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Default");
    }
    private void OnMouseDown()
    {
        if(Dice.access1==true)
        {
            Dice.nbr = sidenmbr;
            if(Dice.tour==1)
            {
                if(Dice.selected==1)
                {
                    bool cantmov=false;
                    for(int i=Dice.pos + 1;i<=Dice.pos+Dice.nbr;i++)
                    {
                        if((Dice.pos1==i && Dice.pos2==i)||(Dice.pos1==i && Dice.pos3==i)||(Dice.pos2==i && Dice.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((folow_the_path.x+Dice.nbr==51 || folow_the_path.x+Dice.nbr==17 || folow_the_path.x+Dice.nbr==34 || folow_the_path.x+Dice.nbr==7 || folow_the_path.x+Dice.nbr==12 || folow_the_path.x+Dice.nbr==24 || folow_the_path.x+Dice.nbr==29 || folow_the_path.x+Dice.nbr==41 || folow_the_path.x+Dice.nbr==46 || folow_the_path.x+Dice.nbr==58 || folow_the_path.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path.x+Dice.nbr || follow_the_path_g1.x==folow_the_path.x+Dice.nbr || follow_the_path_g2.x==folow_the_path.x+Dice.nbr || follow_the_path_g3.x==folow_the_path.x+Dice.nbr || follow_the_path_g4.x==folow_the_path.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice.pos+Dice.nbr<=folow_the_path.Length)
                        {
                            folow_the_path.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selected==2)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice.pos1 + 1;i<=Dice.pos1+Dice.nbr;i++)
                    {
                        if((Dice.pos==i && Dice.pos2==i)||(Dice.pos==i && Dice.pos3==i)||(Dice.pos2==i && Dice.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x+Dice2.nbr==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x+Dice2.nbr==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path1.x+Dice.nbr==51 || folow_the_path1.x+Dice.nbr==17 || folow_the_path1.x+Dice.nbr==34 || folow_the_path1.x+Dice.nbr==7 || folow_the_path1.x+Dice.nbr==12 || folow_the_path1.x+Dice.nbr==24 || folow_the_path1.x+Dice.nbr==29 || folow_the_path1.x+Dice.nbr==41 || folow_the_path1.x+Dice.nbr==46 || folow_the_path1.x+Dice.nbr==58 || folow_the_path1.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path1.x+Dice.nbr || follow_the_path_g1.x==folow_the_path1.x+Dice.nbr || follow_the_path_g2.x==folow_the_path1.x+Dice.nbr || follow_the_path_g3.x==folow_the_path1.x+Dice.nbr || follow_the_path_g4.x==folow_the_path1.x+Dice.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.pos1+Dice.nbr<=folow_the_path1.Length)
                        {
                            folow_the_path1.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selected==3)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice.pos2 + 1;i<=Dice.pos2+Dice.nbr;i++)
                    {
                        if((Dice.pos==i && Dice.pos1==i)||(Dice.pos==i && Dice.pos3==i)||(Dice.pos1==i && Dice.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x+Dice2.nbr==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x+Dice2.nbr==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    
                    if(((folow_the_path2.x+Dice.nbr==51 || folow_the_path2.x+Dice.nbr==17 || folow_the_path2.x+Dice.nbr==34 || folow_the_path2.x+Dice.nbr==7 || folow_the_path2.x+Dice.nbr==12 || folow_the_path2.x+Dice.nbr==24 || folow_the_path2.x+Dice.nbr==29 || folow_the_path2.x+Dice.nbr==41 || folow_the_path2.x+Dice.nbr==46 || folow_the_path2.x+Dice.nbr==58 || folow_the_path2.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path2.x+Dice.nbr || follow_the_path_g1.x==folow_the_path2.x+Dice.nbr || follow_the_path_g2.x==folow_the_path2.x+Dice.nbr || follow_the_path_g3.x==folow_the_path2.x+Dice.nbr || follow_the_path_g4.x==folow_the_path2.x+Dice.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.pos2+Dice.nbr<=folow_the_path2.Length)
                        {
                            folow_the_path2.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selected==4)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice.pos3 + 1;i<=Dice.pos3+Dice.nbr;i++)
                    {
                        if((Dice.pos==i && Dice.pos1==i)||(Dice.pos==i && Dice.pos2==i)||(Dice.pos1==i && Dice.pos2==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path3.x+Dice.nbr==51 || folow_the_path3.x+Dice.nbr==17 || folow_the_path3.x+Dice.nbr==34 || folow_the_path3.x+Dice.nbr==7 || folow_the_path3.x+Dice.nbr==12 || folow_the_path3.x+Dice.nbr==24 || folow_the_path3.x+Dice.nbr==29 || folow_the_path3.x+Dice.nbr==41 || folow_the_path3.x+Dice.nbr==46 || folow_the_path3.x+Dice.nbr==58 || folow_the_path3.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path3.x+Dice.nbr || follow_the_path_g1.x==folow_the_path3.x+Dice.nbr || follow_the_path_g2.x==folow_the_path3.x+Dice.nbr || follow_the_path_g3.x==folow_the_path3.x+Dice.nbr || follow_the_path_g4.x==folow_the_path3.x+Dice.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.pos3+Dice.nbr<=folow_the_path3.Length)
                        {
                            folow_the_path3.click = true; Dice.access1 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }    
            }
            else if(Dice.tour==2)
            {
                if(Dice.selectedy==1)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y1.x + 1;i<=follow_the_path_y1.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y1.x+Dice.nbr==51 || follow_the_path_y1.x+Dice.nbr==17 || follow_the_path_y1.x+Dice.nbr==34 || follow_the_path_y1.x+Dice.nbr==7 || follow_the_path_y1.x+Dice.nbr==12 || follow_the_path_y1.x+Dice.nbr==24 || follow_the_path_y1.x+Dice.nbr==29 || follow_the_path_y1.x+Dice.nbr==41 || follow_the_path_y1.x+Dice.nbr==46 || follow_the_path_y1.x+Dice.nbr==58 || follow_the_path_y1.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y1.x+Dice.nbr || folow_the_path1.x==follow_the_path_y1.x+Dice.nbr || folow_the_path.x==follow_the_path_y1.x+Dice.nbr || folow_the_path3.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y1.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice.posy+Dice.nbr<=follow_the_path_y1.Length)
                        {
                            follow_the_path_y1.click = true; Dice.access1 = false;
                        }
                    } 
                }
                else if(Dice.selectedy==2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_2.x + 1;i<=follow_the_path_y_2.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_2.x+Dice.nbr==51 || follow_the_path_y_2.x+Dice.nbr==17 || follow_the_path_y_2.x+Dice.nbr==34 || follow_the_path_y_2.x+Dice.nbr==7 || follow_the_path_y_2.x+Dice.nbr==12 || follow_the_path_y_2.x+Dice.nbr==24 || follow_the_path_y_2.x+Dice.nbr==29 || follow_the_path_y_2.x+Dice.nbr==41 || follow_the_path_y_2.x+Dice.nbr==46 || follow_the_path_y_2.x+Dice.nbr==58 || follow_the_path_y_2.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_2.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posy1+Dice.nbr<=follow_the_path_y_2.Length)
                        {
                            follow_the_path_y_2.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selectedy==3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_3.x + 1;i<=follow_the_path_y_3.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_3.x+Dice.nbr==51 || follow_the_path_y_3.x+Dice.nbr==17 || follow_the_path_y_3.x+Dice.nbr==34 || follow_the_path_y_3.x+Dice.nbr==7 || follow_the_path_y_3.x+Dice.nbr==12 || follow_the_path_y_3.x+Dice.nbr==24 || follow_the_path_y_3.x+Dice.nbr==29 || follow_the_path_y_3.x+Dice.nbr==41 || follow_the_path_y_3.x+Dice.nbr==46 || follow_the_path_y_3.x+Dice.nbr==58 || follow_the_path_y_3.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_3.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posy2+Dice.nbr<=follow_the_path_y_3.Length)
                        {
                            follow_the_path_y_3.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selectedy==4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_4.x + 1;i<=follow_the_path_y_4.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_4.x+Dice.nbr==51 || follow_the_path_y_4.x+Dice.nbr==17 || follow_the_path_y_4.x+Dice.nbr==34 || follow_the_path_y_4.x+Dice.nbr==7 || follow_the_path_y_4.x+Dice.nbr==12 || follow_the_path_y_4.x+Dice.nbr==24 || follow_the_path_y_4.x+Dice.nbr==29 || follow_the_path_y_4.x+Dice.nbr==41 || follow_the_path_y_4.x+Dice.nbr==46 || follow_the_path_y_4.x+Dice.nbr==58 || follow_the_path_y_4.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_4.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posy3+Dice.nbr<=follow_the_path_y_4.Length)
                        {
                            follow_the_path_y_4.click = true; Dice.access1 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }  
            }
            else
            {
                if(Dice.selectedg==1)
                {
                    Debug.Log("entre a green img");
                    bool cantmov=false;
                    for(int i=follow_the_path_g1.x + 1 ; i<=follow_the_path_g1.x+Dice.nbr ; i++)
                    {
                        if((Dice.posg1==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg3==i)||(Dice.posg2==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                    } 
                    if((follow_the_path_g1.x+Dice.nbr==51 || follow_the_path_g1.x+Dice.nbr==17 || follow_the_path_g1.x+Dice.nbr==34 || follow_the_path_g1.x+Dice.nbr==7 || follow_the_path_g1.x+Dice.nbr==12 || follow_the_path_g1.x+Dice.nbr==24 || follow_the_path_g1.x+Dice.nbr==29 || follow_the_path_g1.x+Dice.nbr==41 || follow_the_path_g1.x+Dice.nbr==46 || follow_the_path_g1.x+Dice.nbr==58 || follow_the_path_g1.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g1.x+Dice.nbr || folow_the_path1.x==follow_the_path_g1.x+Dice.nbr || folow_the_path2.x==follow_the_path_g1.x+Dice.nbr || folow_the_path3.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g1.x+Dice.nbr ))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice.posg+Dice.nbr<=follow_the_path_g1.Length)
                        {
                            Debug.Log("entre a green img mov");
                            follow_the_path_g1.click = true; Dice.access1 = false;
                        }
                    } 
                }
                else if(Dice.selectedg==2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g2.x + 1;i<=follow_the_path_g2.x+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg3==i)||(Dice.posg2==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g2.x+Dice.nbr==51 || follow_the_path_g2.x+Dice.nbr==17 || follow_the_path_g2.x+Dice.nbr==34 || follow_the_path_g2.x+Dice.nbr==7 || follow_the_path_g2.x+Dice.nbr==12 || follow_the_path_g2.x+Dice.nbr==24 || follow_the_path_g2.x+Dice.nbr==29 || follow_the_path_g2.x+Dice.nbr==41 || follow_the_path_g2.x+Dice.nbr==46 || follow_the_path_g2.x+Dice.nbr==58 || follow_the_path_g2.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g2.x+Dice.nbr || folow_the_path1.x==follow_the_path_g2.x+Dice.nbr || folow_the_path2.x==follow_the_path_g2.x+Dice.nbr || folow_the_path3.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g2.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posg1+Dice.nbr<=follow_the_path_g2.Length)
                        {
                            follow_the_path_g2.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selectedg==3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g3.x + 1;i<=follow_the_path_g3.x+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg1==i)||(Dice.posg==i && Dice.posg3==i)||(Dice.posg1==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g3.x+Dice.nbr==51 || follow_the_path_g3.x+Dice.nbr==17 || follow_the_path_g3.x+Dice.nbr==34 || follow_the_path_g3.x+Dice.nbr==7 || follow_the_path_g3.x+Dice.nbr==12 || follow_the_path_g3.x+Dice.nbr==24 || follow_the_path_g3.x+Dice.nbr==29 || follow_the_path_g3.x+Dice.nbr==41 || follow_the_path_g3.x+Dice.nbr==46 || follow_the_path_g3.x+Dice.nbr==58 || follow_the_path_g3.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g3.x+Dice.nbr || folow_the_path1.x==follow_the_path_g3.x+Dice.nbr || folow_the_path2.x==follow_the_path_g3.x+Dice.nbr || folow_the_path3.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g3.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posg2+Dice.nbr<=follow_the_path_y_3.Length)
                        {
                            follow_the_path_g3.click = true; Dice.access1 = false;
                        }
                    }
                }
                else if(Dice.selectedg==4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g4.x + 1;i<=follow_the_path_g4.x+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg1==i)||(Dice.posg==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg2==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cantmov=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g4.x+Dice.nbr==51 || follow_the_path_g4.x+Dice.nbr==17 || follow_the_path_g4.x+Dice.nbr==34 || follow_the_path_g4.x+Dice.nbr==7 || follow_the_path_g4.x+Dice.nbr==12 || follow_the_path_g4.x+Dice.nbr==24 || follow_the_path_g4.x+Dice.nbr==29 || follow_the_path_g4.x+Dice.nbr==41 || follow_the_path_g4.x+Dice.nbr==46 || follow_the_path_g4.x+Dice.nbr==58 || follow_the_path_g4.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g4.x+Dice.nbr || folow_the_path1.x==follow_the_path_g4.x+Dice.nbr || folow_the_path2.x==follow_the_path_g4.x+Dice.nbr || folow_the_path3.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g4.x+Dice.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice.posg3+Dice.nbr<=follow_the_path_g4.Length)
                        {
                            follow_the_path_g4.click = true; Dice.access1 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }  
            }
        }
    }
}
