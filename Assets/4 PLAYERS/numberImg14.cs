using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberImg14 : MonoBehaviour
{
    private static Sprite[] numberSides;
    private static SpriteRenderer rendNembers;
    public static bool show=false;
    static int sidenmbr;
    public static bool autonum2=false;
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
        if(autonum2)
        {
            autonum2=false;
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
        if(Dice4.access2==true)
        {
            Dice4.nbr = sidenmbr;
            if(Dice4.tour==1)
            {
                if(Dice4.selected==1)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice4.pos + 1;i<=Dice4.pos+Dice4.nbr;i++)
                    {
                        if((Dice4.pos1==i && Dice4.pos2==i)||(Dice4.pos1==i && Dice4.pos3==i)||(Dice4.pos2==i && Dice4.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((folow_the_path4.x+Dice4.nbr==51 || folow_the_path4.x+Dice4.nbr==17 || folow_the_path4.x+Dice4.nbr==34 || folow_the_path4.x+Dice4.nbr==7 || folow_the_path4.x+Dice4.nbr==12 || folow_the_path4.x+Dice4.nbr==24 || folow_the_path4.x+Dice4.nbr==29 || folow_the_path4.x+Dice4.nbr==41 || folow_the_path4.x+Dice4.nbr==46 || folow_the_path4.x+Dice4.nbr==58 || folow_the_path4.x+Dice4.nbr==63)&&(follow_the_path_y14.x==folow_the_path4.x+Dice4.nbr || follow_the_path_y_24.x==folow_the_path4.x+Dice4.nbr || follow_the_path_y_34.x==folow_the_path4.x+Dice4.nbr || follow_the_path_y_44.x==folow_the_path4.x+Dice4.nbr || follow_the_path_g14.x==folow_the_path4.x+Dice4.nbr || follow_the_path_g24.x==folow_the_path4.x+Dice4.nbr || follow_the_path_g34.x==folow_the_path4.x+Dice4.nbr || follow_the_path_g44.x==folow_the_path4.x+Dice4.nbr || follow_the_path_b14.x==folow_the_path4.x+Dice4.nbr || follow_the_path_b24.x==folow_the_path4.x+Dice4.nbr || follow_the_path_b34.x==folow_the_path4.x+Dice4.nbr || follow_the_path_b44.x==folow_the_path4.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice4.pos+Dice4.nbr<=folow_the_path4.Length)
                        {
                            folow_the_path4.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selected == 2)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice4.pos1 + 1;i<=Dice4.pos1+Dice4.nbr;i++)
                    {
                        if((Dice4.pos==i && Dice4.pos2==i)||(Dice4.pos==i && Dice4.pos3==i)||(Dice4.pos2==i && Dice4.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x+Dice2.nbr==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x+Dice2.nbr==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path14.x+Dice4.nbr==51 || folow_the_path14.x+Dice4.nbr==17 || folow_the_path14.x+Dice4.nbr==34 || folow_the_path14.x+Dice4.nbr==7 || folow_the_path14.x+Dice4.nbr==12 || folow_the_path14.x+Dice4.nbr==24 || folow_the_path14.x+Dice4.nbr==29 || folow_the_path14.x+Dice4.nbr==41 || folow_the_path14.x+Dice4.nbr==46 || folow_the_path14.x+Dice4.nbr==58 || folow_the_path14.x+Dice4.nbr==63)&&(follow_the_path_y14.x==folow_the_path14.x+Dice4.nbr || follow_the_path_y_24.x==folow_the_path14.x+Dice4.nbr || follow_the_path_y_34.x==folow_the_path14.x+Dice4.nbr || follow_the_path_y_44.x==folow_the_path14.x+Dice4.nbr || follow_the_path_g14.x==folow_the_path14.x+Dice4.nbr || follow_the_path_g24.x==folow_the_path14.x+Dice4.nbr || follow_the_path_g34.x==folow_the_path14.x+Dice4.nbr || follow_the_path_g44.x==folow_the_path14.x+Dice4.nbr || follow_the_path_b14.x==folow_the_path14.x+Dice4.nbr || follow_the_path_b24.x==folow_the_path14.x+Dice4.nbr || follow_the_path_b34.x==folow_the_path14.x+Dice4.nbr || follow_the_path_b44.x==folow_the_path14.x+Dice4.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.pos1+Dice4.nbr<=folow_the_path14.Length)
                        {
                            folow_the_path14.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selected == 3)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice4.pos2 + 1;i<=Dice4.pos2+Dice4.nbr;i++)
                    {
                        if((Dice4.pos==i && Dice4.pos1==i)||(Dice4.pos==i && Dice4.pos3==i)||(Dice4.pos1==i && Dice4.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x+Dice2.nbr==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x+Dice2.nbr==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path24.x+Dice4.nbr==51 || folow_the_path24.x+Dice4.nbr==17 || folow_the_path24.x+Dice4.nbr==34 || folow_the_path24.x+Dice4.nbr==7 || folow_the_path24.x+Dice4.nbr==12 || folow_the_path24.x+Dice4.nbr==24 || folow_the_path24.x+Dice4.nbr==29 || folow_the_path24.x+Dice4.nbr==41 || folow_the_path24.x+Dice4.nbr==46 || folow_the_path24.x+Dice4.nbr==58 || folow_the_path24.x+Dice4.nbr==63)&&(follow_the_path_y14.x==folow_the_path24.x+Dice4.nbr || follow_the_path_y_24.x==folow_the_path24.x+Dice4.nbr || follow_the_path_y_34.x==folow_the_path24.x+Dice4.nbr || follow_the_path_y_44.x==folow_the_path24.x+Dice4.nbr || follow_the_path_g14.x==folow_the_path24.x+Dice4.nbr || follow_the_path_g24.x==folow_the_path24.x+Dice4.nbr || follow_the_path_g34.x==folow_the_path24.x+Dice4.nbr || follow_the_path_g44.x==folow_the_path24.x+Dice4.nbr || follow_the_path_b14.x==folow_the_path24.x+Dice4.nbr || follow_the_path_b24.x==folow_the_path24.x+Dice4.nbr || follow_the_path_b34.x==folow_the_path24.x+Dice4.nbr || follow_the_path_b44.x==folow_the_path24.x+Dice4.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.pos2+Dice4.nbr<=folow_the_path24.Length)
                        {
                            folow_the_path24.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selected == 4)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice4.pos3 + 1;i<=Dice4.pos3+Dice4.nbr;i++)
                    {
                        if((Dice4.pos==i && Dice4.pos1==i)||(Dice4.pos==i && Dice4.pos2==i)||(Dice4.pos1==i && Dice4.pos2==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path34.x+Dice4.nbr==51 || folow_the_path34.x+Dice4.nbr==17 || folow_the_path34.x+Dice4.nbr==34 || folow_the_path34.x+Dice4.nbr==7 || folow_the_path34.x+Dice4.nbr==12 || folow_the_path34.x+Dice4.nbr==24 || folow_the_path34.x+Dice4.nbr==29 || folow_the_path34.x+Dice4.nbr==41 || folow_the_path34.x+Dice4.nbr==46 || folow_the_path34.x+Dice4.nbr==58 || folow_the_path34.x+Dice4.nbr==63)&&(follow_the_path_y14.x==folow_the_path34.x+Dice4.nbr || follow_the_path_y_24.x==folow_the_path34.x+Dice4.nbr || follow_the_path_y_34.x==folow_the_path34.x+Dice4.nbr || follow_the_path_y_44.x==folow_the_path34.x+Dice4.nbr || follow_the_path_g14.x==folow_the_path34.x+Dice4.nbr || follow_the_path_g24.x==folow_the_path34.x+Dice4.nbr || follow_the_path_g34.x==folow_the_path34.x+Dice4.nbr || follow_the_path_g44.x==folow_the_path34.x+Dice4.nbr || follow_the_path_b14.x==folow_the_path34.x+Dice4.nbr || follow_the_path_b24.x==folow_the_path34.x+Dice4.nbr || follow_the_path_b34.x==folow_the_path34.x+Dice4.nbr || follow_the_path_b44.x==folow_the_path34.x+Dice4.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.pos3+Dice4.nbr<=folow_the_path34.Length)
                        {
                            folow_the_path34.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }
            }
            else if(Dice4.tour==2)
            {
                if(Dice4.selectedy==1)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y14.x + 1;i<=follow_the_path_y14.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y14.x+Dice4.nbr==51 || follow_the_path_y14.x+Dice4.nbr==17 || follow_the_path_y14.x+Dice4.nbr==34 || follow_the_path_y14.x+Dice4.nbr==7 || follow_the_path_y14.x+Dice4.nbr==12 || follow_the_path_y14.x+Dice4.nbr==24 || follow_the_path_y14.x+Dice4.nbr==29 || follow_the_path_y14.x+Dice4.nbr==41 || follow_the_path_y14.x+Dice4.nbr==46 || follow_the_path_y14.x+Dice4.nbr==58 || follow_the_path_y14.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_y14.x+Dice4.nbr || folow_the_path14.x==follow_the_path_y14.x+Dice4.nbr || folow_the_path4.x==follow_the_path_y14.x+Dice4.nbr || folow_the_path34.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_y14.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_y14.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice4.posy+Dice4.nbr<=follow_the_path_y14.Length)
                        {
                            follow_the_path_y14.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selectedy == 2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_24.x + 1;i<=follow_the_path_y_24.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if((follow_the_path_y_24.x+Dice4.nbr==51 || follow_the_path_y_24.x+Dice4.nbr==17 || follow_the_path_y_24.x+Dice4.nbr==34 || follow_the_path_y_24.x+Dice4.nbr==7 || follow_the_path_y_24.x+Dice4.nbr==12 || follow_the_path_y_24.x+Dice4.nbr==24 || follow_the_path_y_24.x+Dice4.nbr==29 || follow_the_path_y_24.x+Dice4.nbr==41 || follow_the_path_y_24.x+Dice4.nbr==46 || follow_the_path_y_24.x+Dice4.nbr==58 || follow_the_path_y_24.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_y_24.x+Dice4.nbr || folow_the_path14.x==follow_the_path_y_24.x+Dice4.nbr || folow_the_path24.x==follow_the_path_y_24.x+Dice4.nbr || folow_the_path34.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_y_24.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_y_24.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posy1+Dice4.nbr<=follow_the_path_y_24.Length)
                        {
                            follow_the_path_y_24.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selectedy == 3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_34.x + 1;i<=follow_the_path_y_34.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_34.x+Dice4.nbr==51 || follow_the_path_y_34.x+Dice4.nbr==17 || follow_the_path_y_34.x+Dice4.nbr==34 || follow_the_path_y_34.x+Dice4.nbr==7 || follow_the_path_y_34.x+Dice4.nbr==12 || follow_the_path_y_34.x+Dice4.nbr==24 || follow_the_path_y_34.x+Dice4.nbr==29 || follow_the_path_y_34.x+Dice4.nbr==41 || follow_the_path_y_34.x+Dice4.nbr==46 || follow_the_path_y_34.x+Dice4.nbr==58 || follow_the_path_y_34.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_y_34.x+Dice4.nbr || folow_the_path14.x==follow_the_path_y_34.x+Dice4.nbr || folow_the_path24.x==follow_the_path_y_34.x+Dice4.nbr || folow_the_path34.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_y_34.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_y_34.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posy2+Dice4.nbr<=follow_the_path_y_34.Length)
                        {
                            follow_the_path_y_34.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else if (Dice4.selectedy == 4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_44.x + 1;i<=follow_the_path_y_44.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_44.x+Dice4.nbr==51 || follow_the_path_y_44.x+Dice4.nbr==17 || follow_the_path_y_44.x+Dice4.nbr==34 || follow_the_path_y_44.x+Dice4.nbr==7 || follow_the_path_y_44.x+Dice4.nbr==12 || follow_the_path_y_44.x+Dice4.nbr==24 || follow_the_path_y_44.x+Dice4.nbr==29 || follow_the_path_y_44.x+Dice4.nbr==41 || follow_the_path_y_44.x+Dice4.nbr==46 || follow_the_path_y_44.x+Dice4.nbr==58 || follow_the_path_y_44.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_y_44.x+Dice4.nbr || folow_the_path14.x==follow_the_path_y_44.x+Dice4.nbr || folow_the_path24.x==follow_the_path_y_44.x+Dice4.nbr || folow_the_path34.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_y_44.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_y_44.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posy3+Dice4.nbr<=follow_the_path_y_44.Length)
                        {
                            follow_the_path_y_44.click = true;Dice4.access2 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }
            }
            else if(Dice4.tour==3)
            {
                if(Dice4.selectedg==1)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g14.x + 1;i<=follow_the_path_g14.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    } 
                    if((follow_the_path_g14.x+Dice4.nbr==51 || follow_the_path_g14.x+Dice4.nbr==17 || follow_the_path_g14.x+Dice4.nbr==34 || follow_the_path_g14.x+Dice4.nbr==7 || follow_the_path_g14.x+Dice4.nbr==12 || follow_the_path_g14.x+Dice4.nbr==24 || follow_the_path_g14.x+Dice4.nbr==29 || follow_the_path_g14.x+Dice4.nbr==41 || follow_the_path_g14.x+Dice4.nbr==46 || follow_the_path_g14.x+Dice4.nbr==58 || follow_the_path_g14.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_g14.x+Dice4.nbr || folow_the_path14.x==follow_the_path_g14.x+Dice4.nbr || folow_the_path24.x==follow_the_path_g14.x+Dice4.nbr || folow_the_path34.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_g14.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_g14.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice4.posg+Dice4.nbr<=follow_the_path_g14.Length)
                        {
                            follow_the_path_g14.click = true; Dice4.access2 = false;
                        }
                    } 
                }
                else if(Dice4.selectedg==2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g24.x + 1;i<=follow_the_path_g24.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g24.x+Dice4.nbr==51 || follow_the_path_g24.x+Dice4.nbr==17 || follow_the_path_g24.x+Dice4.nbr==34 || follow_the_path_g24.x+Dice4.nbr==7 || follow_the_path_g24.x+Dice4.nbr==12 || follow_the_path_g24.x+Dice4.nbr==24 || follow_the_path_g24.x+Dice4.nbr==29 || follow_the_path_g24.x+Dice4.nbr==41 || follow_the_path_g24.x+Dice4.nbr==46 || follow_the_path_g24.x+Dice4.nbr==58 || follow_the_path_g24.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_g24.x+Dice4.nbr || folow_the_path14.x==follow_the_path_g24.x+Dice4.nbr || folow_the_path24.x==follow_the_path_g24.x+Dice4.nbr || folow_the_path34.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_g24.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_g24.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }   
                    if (cantmov==false)
                    {
                        if(Dice4.posg1+Dice4.nbr<=follow_the_path_g24.Length)
                        {
                            follow_the_path_g24.click = true; Dice4.access2 = false;
                        }
                    }
                }
                else if(Dice4.selectedg==3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g34.x + 1;i<=follow_the_path_g34.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g34.x+Dice4.nbr==51 || follow_the_path_g34.x+Dice4.nbr==17 || follow_the_path_g34.x+Dice4.nbr==34 || follow_the_path_g34.x+Dice4.nbr==7 || follow_the_path_g34.x+Dice4.nbr==12 || follow_the_path_g34.x+Dice4.nbr==24 || follow_the_path_g34.x+Dice4.nbr==29 || follow_the_path_g34.x+Dice4.nbr==41 || follow_the_path_g34.x+Dice4.nbr==46 || follow_the_path_g34.x+Dice4.nbr==58 || follow_the_path_g34.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_g34.x+Dice4.nbr || folow_the_path14.x==follow_the_path_g34.x+Dice4.nbr || folow_the_path24.x==follow_the_path_g34.x+Dice4.nbr || folow_the_path34.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_g34.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_g34.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posg2+Dice4.nbr<=follow_the_path_y_34.Length)
                        {
                            follow_the_path_g34.click = true; Dice4.access2 = false;
                        }
                    }
                }
                else if(Dice4.selectedg==4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_g44.x + 1;i<=follow_the_path_g44.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_g44.x+Dice4.nbr==51 || follow_the_path_g44.x+Dice4.nbr==17 || follow_the_path_g44.x+Dice4.nbr==34 || follow_the_path_g44.x+Dice4.nbr==7 || follow_the_path_g44.x+Dice4.nbr==12 || follow_the_path_g44.x+Dice4.nbr==24 || follow_the_path_g44.x+Dice4.nbr==29 || follow_the_path_g44.x+Dice4.nbr==41 || follow_the_path_g44.x+Dice4.nbr==46 || follow_the_path_g44.x+Dice4.nbr==58 || follow_the_path_g44.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_g44.x+Dice4.nbr || folow_the_path14.x==follow_the_path_g44.x+Dice4.nbr || folow_the_path24.x==follow_the_path_g44.x+Dice4.nbr || folow_the_path34.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_b14.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_b24.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_b34.x==follow_the_path_g44.x+Dice4.nbr || follow_the_path_b44.x==follow_the_path_g44.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posg3+Dice4.nbr<=follow_the_path_g44.Length)
                        {
                            follow_the_path_g44.click = true; Dice4.access2 = false;
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
                if(Dice4.selectedb==1)
                {
                    Debug.Log("entre a blue img");
                    bool cantmov=false;
                    for(int i=follow_the_path_b14.x + 1;i<=follow_the_path_b14.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_b24.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                    } 
                    if((follow_the_path_b14.x+Dice4.nbr==51 || follow_the_path_b14.x+Dice4.nbr==17 || follow_the_path_b14.x+Dice4.nbr==34 || follow_the_path_b14.x+Dice4.nbr==7 || follow_the_path_b14.x+Dice4.nbr==12 || follow_the_path_b14.x+Dice4.nbr==24 || follow_the_path_b14.x+Dice4.nbr==29 || follow_the_path_b14.x+Dice4.nbr==41 || follow_the_path_b14.x+Dice4.nbr==46 || follow_the_path_b14.x+Dice4.nbr==58 || follow_the_path_b14.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_b14.x+Dice4.nbr || folow_the_path14.x==follow_the_path_b14.x+Dice4.nbr || folow_the_path24.x==follow_the_path_b14.x+Dice4.nbr || folow_the_path34.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_b14.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_b14.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice4.posb+Dice4.nbr<=Dice4.l)
                        {
                            Debug.Log("entre a blue img mov");
                            follow_the_path_b14.click = true; Dice4.access2 = false;
                        }
                    } 
                }
                else if(Dice4.selectedb==2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_b24.x + 1;i<=follow_the_path_b24.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i)||(follow_the_path_b34.x==i && follow_the_path_b44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_b24.x+Dice4.nbr==51 || follow_the_path_b24.x+Dice4.nbr==17 || follow_the_path_b24.x+Dice4.nbr==34 || follow_the_path_b24.x+Dice4.nbr==7 || follow_the_path_b24.x+Dice4.nbr==12 || follow_the_path_b24.x+Dice4.nbr==24 || follow_the_path_b24.x+Dice4.nbr==29 || follow_the_path_b24.x+Dice4.nbr==41 || follow_the_path_b24.x+Dice4.nbr==46 || follow_the_path_b24.x+Dice4.nbr==58 || follow_the_path_b24.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_b24.x+Dice4.nbr || folow_the_path14.x==follow_the_path_b24.x+Dice4.nbr || folow_the_path24.x==follow_the_path_b24.x+Dice4.nbr || folow_the_path34.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_b24.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_b24.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }   
                    if (cantmov==false)
                    {
                        if(Dice4.posb1+Dice4.nbr<=Dice4.l)
                        {
                            follow_the_path_b24.click = true; Dice4.access2 = false;
                        }
                    }
                }
                else if(Dice4.selectedb==3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_b34.x + 1;i<=follow_the_path_b34.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b44.x==i)||(follow_the_path_b24.x==i && follow_the_path_b44.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_b34.x+Dice4.nbr==51 || follow_the_path_b34.x+Dice4.nbr==17 || follow_the_path_b34.x+Dice4.nbr==34 || follow_the_path_b34.x+Dice4.nbr==7 || follow_the_path_b34.x+Dice4.nbr==12 || follow_the_path_b34.x+Dice4.nbr==24 || follow_the_path_b34.x+Dice4.nbr==29 || follow_the_path_b34.x+Dice4.nbr==41 || follow_the_path_b34.x+Dice4.nbr==46 || follow_the_path_b34.x+Dice4.nbr==58 || follow_the_path_b34.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_b34.x+Dice4.nbr || folow_the_path14.x==follow_the_path_b34.x+Dice4.nbr || folow_the_path24.x==follow_the_path_b34.x+Dice4.nbr || folow_the_path34.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_b34.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_b34.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posb2+Dice4.nbr<=Dice4.l)
                        {
                            follow_the_path_b34.click = true; Dice4.access2 = false;
                        }
                    }
                }
                else if(Dice4.selectedb==4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_b44.x + 1;i<=follow_the_path_b44.x+Dice4.nbr;i++)
                    {
                        if((follow_the_path_b14.x==i && follow_the_path_b24.x==i)||(follow_the_path_b14.x==i && follow_the_path_b34.x==i)||(follow_the_path_b24.x==i && follow_the_path_b34.x==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice4.posy);
                            cantmov=true;
                        }
                        if((folow_the_path4.x==i && folow_the_path14.x==i)||(folow_the_path4.x==i && folow_the_path24.x==i)||(folow_the_path4.x==i && folow_the_path34.x==i)||(folow_the_path14.x==i && folow_the_path24.x==i)||(folow_the_path14.x==i && folow_the_path34.x==i)||(folow_the_path24.x==i && folow_the_path34.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y14.x==i && follow_the_path_y_24.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y14.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_34.x==i)||(follow_the_path_y_24.x==i && follow_the_path_y_44.x==i)||(follow_the_path_y_34.x==i && follow_the_path_y_44.x==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_g14.x==i && follow_the_path_g24.x==i)||(follow_the_path_g14.x==i && follow_the_path_g34.x==i)||(follow_the_path_g14.x==i && follow_the_path_g44.x==i)||(follow_the_path_g24.x==i && follow_the_path_g34.x==i)||(follow_the_path_g24.x==i && follow_the_path_g44.x==i)||(follow_the_path_g34.x==i && follow_the_path_g44.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_b44.x+Dice4.nbr==51 || follow_the_path_b44.x+Dice4.nbr==17 || follow_the_path_b44.x+Dice4.nbr==34 || follow_the_path_b44.x+Dice4.nbr==7 || follow_the_path_b44.x+Dice4.nbr==12 || follow_the_path_b44.x+Dice4.nbr==24 || follow_the_path_b44.x+Dice4.nbr==29 || follow_the_path_b44.x+Dice4.nbr==41 || follow_the_path_b44.x+Dice4.nbr==46 || follow_the_path_b44.x+Dice4.nbr==58 || follow_the_path_b44.x+Dice4.nbr==63)&&(folow_the_path4.x==follow_the_path_b44.x+Dice4.nbr || folow_the_path14.x==follow_the_path_b44.x+Dice4.nbr || folow_the_path24.x==follow_the_path_b44.x+Dice4.nbr || folow_the_path34.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_y14.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_y_24.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_y_34.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_y_44.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_g14.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_g24.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_g34.x==follow_the_path_b44.x+Dice4.nbr || follow_the_path_g44.x==follow_the_path_b44.x+Dice4.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice4.posb3+Dice4.nbr<=Dice4.l)
                        {
                            follow_the_path_b44.click = true; Dice4.access2 = false;
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
