using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_ai
{
    public partial class Form1 : Form
    {
        //variables
        public int leftghost1, leftghost2, leftghost3, leftghost4, left;
        public int topghost1, topghost2, topghost3, topghost4, top;
        public int next, direzione, temp = 1;
        public bool pacturn, ghost1turn, ghost2turn, ghost3turn, ghost4turn, start, ghost1eaten, ghost2eaten, ghost3eaten, ghost4eaten, g1ate, g2ate, g3ate, g4ate;
        public bool dir1, dir2, dir3, dir4, c, Supermod, Supermod1, Supermod2, Supermod3, Supermod4, v1, v2, v3, v4, tresec = true;
        public int random1, random2, random3, random4, life = 3, tic4, tic5, tic6, point;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int prec1, prec2, prec3, prec4, startdirection = 1, ghost1speed = 2, ghost2speed = 2, ghost3speed = 2, ghost4speed = 2;
        public Random rand = new Random();
        public List<object> obj = new List<object>();
      

        public Form1()
        {
            InitializeComponent();
            obj.Add(label4);
            obj.Add(label5);
            obj.Add(label6);
            obj.Add(label7);
            obj.Add(label8);
            obj.Add(label9);
            obj.Add(label10);
            obj.Add(label11);
            obj.Add(label12);
            obj.Add(label13);
            obj.Add(label14);
            obj.Add(label15);
            obj.Add(label16);
            obj.Add(label17);
            obj.Add(label18);
            obj.Add(label19);
            obj.Add(label20);
            obj.Add(label21);
            obj.Add(label22);
            obj.Add(label23);
            obj.Add(label24);
            obj.Add(label25);
            obj.Add(label26);
            obj.Add(label27);
            obj.Add(label28);
            obj.Add(label29);
            obj.Add(label30);
            obj.Add(label31);
            obj.Add(label32);
            obj.Add(label33);
            obj.Add(label34);
            obj.Add(label35);
            obj.Add(label36);
            obj.Add(label37);
            obj.Add(label38);
            obj.Add(label39);
            obj.Add(label40);
            obj.Add(label41);
            obj.Add(label42);
            obj.Add(label43);
            obj.Add(label44);
            obj.Add(label45);
            obj.Add(label46);
            obj.Add(label47);
            obj.Add(label48);
            obj.Add(label49);
            obj.Add(label50);
            obj.Add(label51);
            obj.Add(label52);
            obj.Add(label53);
            obj.Add(label54);
            obj.Add(label55);
            obj.Add(label56);
            obj.Add(label57);
            obj.Add(label58);
            obj.Add(label59);
            obj.Add(label60);
            obj.Add(label61);
            obj.Add(label62);
            obj.Add(label63);
            obj.Add(label64);
            obj.Add(label65);
            obj.Add(label66);
            obj.Add(label67);
            obj.Add(label68);
            obj.Add(label69);
            obj.Add(label70);
            obj.Add(label71);
            obj.Add(label72);
            obj.Add(label73);
            obj.Add(label74);
            obj.Add(label75);
            obj.Add(label76);
            obj.Add(label77);
            obj.Add(label78);
            obj.Add(label79);
            obj.Add(label80);
            obj.Add(label81);
            obj.Add(label82);
            obj.Add(label83);
            obj.Add(label84);
            obj.Add(label85);
            obj.Add(label86);
            obj.Add(label87);
            obj.Add(label88);
            obj.Add(label89);
            obj.Add(label90);
            obj.Add(label91);
            obj.Add(label92);
            obj.Add(label93);
            obj.Add(label94);
            obj.Add(label95);
            obj.Add(label96);
            obj.Add(label97);
            obj.Add(label98);
            obj.Add(label99);
            obj.Add(label100);
            obj.Add(label101);
            obj.Add(label102);
            obj.Add(label103);
            obj.Add(label104);
            obj.Add(label105);
            obj.Add(label106);
            obj.Add(label107);
            obj.Add(label108);
            obj.Add(label109);
            obj.Add(label110);
            obj.Add(label111);
            obj.Add(label112);
            obj.Add(label113);
            obj.Add(label114);
            obj.Add(label115);
            obj.Add(label116);
            obj.Add(label117);
            obj.Add(label118);
            obj.Add(label119);
            obj.Add(label120);
            obj.Add(label121);
            obj.Add(label122);
            obj.Add(label123);
            obj.Add(label125);
            obj.Add(label126);
            obj.Add(label127);
            obj.Add(label128);
            obj.Add(label129);
            obj.Add(label130);
            obj.Add(label131);
            obj.Add(label132);
            obj.Add(label133);
            obj.Add(label134);
            obj.Add(label135);
            obj.Add(label136);
            obj.Add(label137);
            obj.Add(label138);
            obj.Add(label139);
            obj.Add(label140);
            obj.Add(label143);
            obj.Add(label144);
            obj.Add(label145);
            obj.Add(label146);
            obj.Add(label147);
            obj.Add(label148);
            obj.Add(label149);
            obj.Add(label150);
            obj.Add(label151);
            obj.Add(label152);
            obj.Add(label153);
            obj.Add(label154);
            obj.Add(label155);
            obj.Add(label156);
            obj.Add(label157);
            obj.Add(label158);
            obj.Add(label159);
            obj.Add(label160);
            obj.Add(label161);
            obj.Add(label162);
            obj.Add(label163);
            obj.Add(label164);
            obj.Add(label165);
            obj.Add(label166);
            obj.Add(label167);
            obj.Add(label168);
            obj.Add(label169);
            obj.Add(label170);
            obj.Add(label171);
            obj.Add(label172);
            obj.Add(label173);
            obj.Add(label174);
            obj.Add(label175);
            obj.Add(label176);
            obj.Add(label177);
            obj.Add(label178);
            obj.Add(label179);
            obj.Add(label180);
            obj.Add(label181);
            obj.Add(label182);
            obj.Add(label183);
            obj.Add(label184);
            obj.Add(label185);
            obj.Add(label186);
            obj.Add(label187);
            obj.Add(label188);
            obj.Add(label189);
            obj.Add(label190);
            obj.Add(label191);
            obj.Add(label192);
            obj.Add(label193);
            obj.Add(label194);
            obj.Add(label195);
            obj.Add(label196);
            obj.Add(label197);
            obj.Add(label198);
            obj.Add(label199);
            obj.Add(label200);
            obj.Add(label201);
            obj.Add(label202);
            obj.Add(label203);
            obj.Add(label204);
            obj.Add(label205);
            obj.Add(label206);
            obj.Add(label207);
            obj.Add(label208);
            obj.Add(label209);
            obj.Add(label210);
            obj.Add(label211);
            obj.Add(label212);
            obj.Add(label213);
            obj.Add(label214);
            obj.Add(label215);
            obj.Add(label216);
            obj.Add(label217);
            obj.Add(label218);
            obj.Add(label219);
            obj.Add(label220);
            obj.Add(label221);
            obj.Add(label222);
            obj.Add(label223);
            obj.Add(label224);
            obj.Add(label225);
            obj.Add(label226);
            obj.Add(label227);
            obj.Add(label228);
            obj.Add(label229);
            obj.Add(label230);
            obj.Add(label231);
            obj.Add(label232);
            obj.Add(label233);
            obj.Add(label234);
            obj.Add(label235);
            obj.Add(label236);
            obj.Add(label237);
            obj.Add(label238);
            obj.Add(label239);
            obj.Add(label240);
            obj.Add(label241);
            obj.Add(label242);
            obj.Add(label243);
            obj.Add(label244);
            obj.Add(label245);
            obj.Add(label246);
            obj.Add(label247);
            obj.Add(label248);
            obj.Add(label249);
            obj.Add(label250);
            obj.Add(label251);
            obj.Add(label252);
            obj.Add(label256);
            obj.Add(label257);
            obj.Add(label258);
            obj.Add(label259);
            obj.Add(label260);
            obj.Add(label261);
            obj.Add(label262);
            obj.Add(label263);
            obj.Add(label264);
            obj.Add(label265);
            obj.Add(label266);
            obj.Add(label267);
            obj.Add(label268);
            obj.Add(label269);
            obj.Add(label270);
            obj.Add(label271);
            obj.Add(label272);
            obj.Add(label273);
            obj.Add(label274);
            obj.Add(label275);
            obj.Add(label276);
            obj.Add(label277);
            obj.Add(label278);
            obj.Add(label279);
            obj.Add(label280);
            obj.Add(label281);
            obj.Add(label282);
            obj.Add(label283);
            obj.Add(label284);
            obj.Add(label285);
            obj.Add(label286);
            obj.Add(label287);
            obj.Add(label288);
            obj.Add(label289);
            obj.Add(label290);
            obj.Add(label291);
            obj.Add(label292);
            obj.Add(label293);
            obj.Add(label294);
            obj.Add(label295);
            obj.Add(label296);
            obj.Add(label297);
            obj.Add(label298);
            obj.Add(label299);
            obj.Add(label300);
            obj.Add(label301);
            obj.Add(label302);
            obj.Add(label303);
            obj.Add(label304);
            obj.Add(label305);
            obj.Add(label306);
            obj.Add(label307);
            obj.Add(label308);
            obj.Add(label309);
            obj.Add(label310);
            obj.Add(label311);
            obj.Add(label312);
            obj.Add(label313);
            obj.Add(label314);
            obj.Add(label315);
            obj.Add(label316);
            obj.Add(label317);
            obj.Add(label318);
            obj.Add(label319);
            obj.Add(label320);
            obj.Add(label321);
            obj.Add(label322);
            obj.Add(label323);
            obj.Add(label324);
            obj.Add(label325);
            obj.Add(label326);
            obj.Add(label327);
            obj.Add(label328);
            obj.Add(label329);
            obj.Add(label330);
            obj.Add(label331);
            obj.Add(label332);
            obj.Add(label333);
            obj.Add(label334);
            obj.Add(label335);
            obj.Add(label336);
            obj.Add(label337);
            obj.Add(label338);
            obj.Add(label339);
            obj.Add(label340);
            obj.Add(label341);
        }

        //start
        private void button1_Click(object sender, EventArgs e)
        {
            start = true;
            lifes();
            points();
            panel1.Visible = false;
            resetall();
        }

        //input
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) next = 1;
            if (e.KeyCode == Keys.Right) next = 2;
            if (e.KeyCode == Keys.Up) next = 3;
            if (e.KeyCode == Keys.Down) next = 4;
            if (e.KeyCode == Keys.Escape) Close();
            temp = next;
        }

        //button style1
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.playgame;
        }

        //button style1
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.playgame2;
        }

        //timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pacman.Enabled)
            {
                direction();
                freedirection();
            }
            if (ghost1.Enabled || ghost2.Enabled || ghost3.Enabled || ghost4.Enabled)
            {
                ghost();
            }
            if (c) control();
            supermod();
            points();
            clash();
        }

        //timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = false;
            c = true;
        }

        //timer3
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ghost2.Top == 180) startdirection = 2;
            if (ghost2.Top == 192) startdirection = 1;
            if (startdirection == 1)
            {
                ghost2.Top--;
                ghost4.Top--;
            }
            if (startdirection == 2)
            {
                ghost2.Top++;
                ghost4.Top++;
            }
        }

        //timer4
        private void timer4_Tick(object sender, EventArgs e)
        {
            tic4++;
            if (ghost3.Top > 150 && tic4 > 100) { prec1 = 3; ghost3.Top--; }
            if (ghost3.Top == 150) timer4.Enabled = false;
        }

        //timer5
        private void timer5_Tick(object sender, EventArgs e)
        {
            tic5++;
            if (ghost2.Left > 153 && ghost2.Left < 176 && tic5 > 300) ghost2.Left++;
            if (ghost2.Top > 150 && ghost2.Left == 176) { ghost2.Top--; }
            if (ghost2.Top == 150) { timer6.Enabled = true; timer5.Enabled = false; }
        }

        //timer6
        private void timer6_Tick(object sender, EventArgs e)
        {
            tic6++;
            if (ghost4.Left > 176 && ghost4.Left < 200 && tic6 > 100) ghost4.Left--;
            if (ghost4.Top > 150 && ghost4.Left == 176) { ghost4.Top--; }
            if (ghost4.Top == 150) timer6.Enabled = false;
        }

        private void powermod_Tick(object sender, EventArgs e)
        {
            tresec = false;
            if (!g1ate)
            {
                v1 = false;
                ghost1eaten = true;
                Supermod1 = false;
                ghost1speed = 2;
            }
            if (!g2ate)
            {
                v2 = false;
                ghost2eaten = true;
                Supermod2 = false;
                ghost2speed = 2;
            }
            if (!g3ate)
            {
                v3 = false;
                ghost3eaten = true;
                Supermod3 = false;
                ghost3speed = 2;
            }
            if (!g4ate)
            {
                v4 = false;
                ghost4eaten = true;
                Supermod4 = false;
                ghost4speed = 2;
            }
            Supermod = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;
            if (prec1 == 1 && !g1ate) { if (ghost1.Left % 2 == 0) leftghost1 = ghost1speed; ghost1.Image = Properties.Resources.rdx; }
            if (prec1 == 2 && !g1ate) { if (ghost1.Left % 2 == 0) leftghost1 = -ghost1speed; ghost1.Image = Properties.Resources.rsx; }
            if (prec1 == 3 && !g1ate) { if (ghost1.Top % 2 == 0) topghost1 = -ghost1speed; ghost1.Image = Properties.Resources.rup; }
            if (prec1 == 4 && !g1ate) { if (ghost1.Top % 2 == 0) topghost1 = ghost1speed; ghost1.Image = Properties.Resources.rdown; }

            if (prec2 == 1 && !g2ate) { if (ghost2.Left % 2 == 0) leftghost2 = ghost2speed; ghost2.Image = Properties.Resources.adx; }
            if (prec2 == 2 && !g2ate) { if (ghost2.Left % 2 == 0) leftghost2 = -ghost2speed; ghost2.Image = Properties.Resources.asx; }
            if (prec2 == 3 && !g2ate) { if (ghost2.Top % 2 == 0) topghost2 = -ghost2speed; ghost2.Image = Properties.Resources.aup; }
            if (prec2 == 4 && !g2ate) { if (ghost2.Top % 2 == 0) topghost2 = ghost2speed; ghost2.Image = Properties.Resources.adown; }

            if (prec3 == 1 && !g3ate) { if (ghost3.Left % 2 == 0) leftghost3 = ghost3speed; ghost3.Image = Properties.Resources.vdx; }
            if (prec3 == 2 && !g3ate) { if (ghost3.Left % 2 == 0) leftghost3 = -ghost3speed; ghost3.Image = Properties.Resources.vsx; }
            if (prec3 == 3 && !g3ate) { if (ghost3.Top % 2 == 0) topghost3 = -ghost3speed; ghost3.Image = Properties.Resources.vup; }
            if (prec3 == 4 && !g3ate) { if (ghost3.Top % 2 == 0) topghost3 = ghost3speed; ghost3.Image = Properties.Resources.vdown; }

            if (prec4 == 1 && !g4ate) { if (ghost4.Left % 2 == 0) leftghost4 = ghost4speed; ghost4.Image = Properties.Resources.gdx; }
            if (prec4 == 2 && !g4ate) { if (ghost4.Left % 2 == 0) leftghost4 = -ghost4speed; ghost4.Image = Properties.Resources.gsx; }
            if (prec4 == 3 && !g4ate) { if (ghost4.Top % 2 == 0) topghost4 = -ghost4speed; ghost4.Image = Properties.Resources.gup; }
            if (prec4 == 4&& !g4ate) { if (ghost4.Top % 2 == 0) topghost4 = ghost4speed; ghost1.Image = Properties.Resources.gdown; }
        }

        //timer8
        private void timer8_Tick(object sender, EventArgs e)
        {
            pacman.SetBounds(pacman.Left, pacman.Top, 0, 0);
            g1ate = false;
            g2ate = false;
            g3ate = false;
            g4ate = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1eaten = true;
            ghost2eaten = true;
            ghost3eaten = true;
            ghost4eaten = true;
            ghost1.Visible = false;
            ghost2.Visible = false;
            ghost3.Visible = false;
            ghost4.Visible = false;
            pacman.Visible = false;
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            Supermod = false;
            Supermod1 = false;
            Supermod2 = false;
            Supermod3 = false;
            Supermod4 = false;
            ghost1speed = 2;
            ghost2speed = 2;
            ghost3speed = 2;
            ghost4speed = 2;
            life--;
            lifes();
            prec1 = 0;
            prec2 = 0;
            prec3 = 0;
            prec4 = 0;
            startdirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direzione = 0;
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftghost1 = 0;
            leftghost2 = 0;
            leftghost3 = 0;
            leftghost4 = 0;
            topghost1 = 0;
            topghost2 = 0;
            topghost3 = 0;
            topghost4 = 0;
            left = 0;
            top = 0;
            timer8.Enabled = false;
            pacman.Image = Properties.Resources._1dx;
            ghost1.Image = Properties.Resources.rup;
            ghost2.Image = Properties.Resources.aup;
            ghost3.Image = Properties.Resources.vup;
            ghost4.Image = Properties.Resources.gup;
            ghost1.Visible = true;
            ghost2.Visible = true;
            ghost3.Visible = true;
            ghost4.Visible = true;
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
            pacman.Visible = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer8.Interval = 1900;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            button1.Visible = true;
            timer9.Enabled = false;
        }

        private void resetall()
        {
            g1ate = false;
            g2ate = false;
            g3ate = false;
            g4ate = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1eaten = true;
            ghost2eaten = true;
            ghost3eaten = true;
            ghost4eaten = true;
            label124.Visible = false;
            label141.Visible = false;
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            Supermod = false;
            Supermod1 = false;
            Supermod2 = false;
            Supermod3 = false;
            Supermod4 = false;
            ghost1speed = 2;
            ghost2speed = 2;
            ghost3speed = 2;
            ghost4speed = 2;
            lifes();
            prec1 = 0;
            prec2 = 0;
            prec3 = 0;
            prec4 = 0;
            startdirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direzione = 0;
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftghost1 = 0;
            leftghost2 = 0;
            leftghost3 = 0;
            leftghost4 = 0;
            topghost1 = 0;
            topghost2 = 0;
            topghost3 = 0;
            topghost4 = 0;
            left = 0;
            top = 0;
            pacman.Image = Properties.Resources._1dx;
            ghost1.Image = Properties.Resources.rup;
            ghost2.Image = Properties.Resources.aup;
            ghost3.Image = Properties.Resources.vup;
            ghost4.Image = Properties.Resources.gup;
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;
            if (start)
            {
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            start = false;
            for (int i = 0; i < 332; i++) ((Label)obj[i]).Visible = true;
        }
        //timer7
        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Enabled = false;
            panel1.Visible = true;
            wating.Enabled = true;
        }

        //timer wating
        private void attendo_Tick(object sender, EventArgs e)
        {
            resetall();
            wating.Enabled = false;
        }

        //initial movement of ghosts
        private void control()
        {
            if (ghost2.Top == 185) { timer3.Enabled = false; timer4.Enabled = true; c = false; timer5.Enabled = true; }
        }

        //lifes
        private void lifes()
        {
            if (life == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (life == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            if (life == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
        private void supermod()
        {
            if (pacman.Bounds.IntersectsWith(label173.Bounds) && label173.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label307.Bounds) && label307.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label220.Bounds) && label220.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label71.Bounds) && label71.Visible == true) supermod2();
        }
        private void supermod2()
        {
            if (!g1ate)
            {
                v1 = false;
                ghost1speed = 2;
                Supermod1 = true;
                ghost1.Image = Properties.Resources.crazy;
                ghost1eaten = true;
            }
            if (!g2ate)
            {
                v2 = false;
                ghost2speed = 2;
                Supermod2 = true;
                ghost2.Image = Properties.Resources.crazy;
                ghost2eaten = true;
            }
            if (!g3ate)
            {
                v3 = false;
                ghost3speed = 2;
                Supermod3 = true;
                ghost3.Image = Properties.Resources.crazy;
                ghost3eaten = true;
            }
            if (!g4ate)
            {
                v4 = false;
                ghost4speed = 2;
                Supermod4 = true;
                ghost4.Image = Properties.Resources.crazy;
                ghost4eaten = true;
            }
            powermod.Enabled = false;
            powermod1.Enabled = false;
            powermod1.Enabled = true;
            tresec = false;
            powermod.Enabled = true;
            Supermod = true;
        }
        private void powermod1_Tick(object sender, EventArgs e)
        {
            tresec = true;
            powermod1.Enabled = false;

        }
        //A clash between characters
        private void clash()
        {
            if (pacman.Bounds.IntersectsWith(ghost1.Bounds) || pacman.Bounds.IntersectsWith(ghost2.Bounds) || pacman.Bounds.IntersectsWith(ghost3.Bounds) || pacman.Bounds.IntersectsWith(ghost4.Bounds))
            {
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) ate();
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) ate();
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) ate();
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) ate();
                if (Supermod)
                {
                    if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) ate(); 
                    if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) ate();
                    if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) ate();
                    if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) ate();
                }
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && ghost1eaten && Supermod1)
                {
                    g1ate = true;
                    v1 = true;
                    ghost1eaten = false;
                    timer1.Enabled = false;
                    ghostate.Enabled = true;
                    ghost1speed = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && ghost2eaten && Supermod2)
                {
                    g2ate = true;
                    v2 = true;
                    ghost2eaten = false;
                    timer1.Enabled = false;
                    ghostate.Enabled = true;
                    ghost2speed = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && ghost3eaten && Supermod3)
                {
                    g3ate = true;
                    v3 = true;
                    ghost3eaten = false;
                    timer1.Enabled = false;
                    ghostate.Enabled = true;
                    ghost3speed = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && ghost4eaten && Supermod4)
                {
                    g4ate = true;
                    v4 = true;
                    ghost4eaten = false;
                    timer1.Enabled = false;
                    ghostate.Enabled = true;
                    ghost4speed = 4;
                }
            }
        }

        private void ghostate_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ghostate.Enabled = false;
        }
        //pacman was eaten
        private void ate()
        {
            pacman.Image = Properties.Resources.pacmorto;
            if (life - 1 <= 0)
            {
                label124.Visible = true;
                endgame();
            }
            else
            {
                top = 0;
                left = 0;
                topghost1 = 0;
                topghost2 = 0;
                topghost3 = 0;
                topghost4 = 0;
                leftghost1 = 0;
                leftghost2 = 0;
                leftghost3 = 0;
                leftghost4 = 0;
                timer1.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                pacturn = false;
                ghost1turn = false;
                ghost2turn = false;
                ghost3turn = false;
                ghost4turn = false;
                timer8.Enabled = true;
            }
        }

        //point control
        private void points()
        {
            for (int i = 0; i < 332; i++)
            {
                if (((Label)obj[i]).Visible == true && pacman.Bounds.IntersectsWith(((Label)obj[i]).Bounds))
                {
                    point += 1;
                    ((Label)obj[i]).Visible = false;
                }
            }
            score.Text = point.ToString();
            if (point >= 332) { endgame(); label141.Visible = true; }
        }

        //game end
        private void endgame()
        {
            point = 0;
            life = 3;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            powermod1.Enabled = false;
            powermod.Enabled = false;
            timer7.Enabled = true;
        }
        //change direction of pacman
        private void freedirection()
        {
            switch (direzione)
            {
                case 1:
                    if (next == 2)
                    {
                        left = 2;
                        pacman.Image = Properties.Resources.pacdx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 2:
                    if (next == 1)
                    {
                        left = -2;
                        pacman.Image = Properties.Resources.pacsx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 3:
                    if (next == 4)
                    {
                        top = 2;
                        pacman.Image = Properties.Resources.pacdown;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 4:
                    if (next == 3)
                    {
                        top = -2;
                        pacman.Image = Properties.Resources.pacup;
                        direzione = next;
                        temp = next;
                    }
                    break;
            }
        }
        //change direction of the ghosts and pacman
        private void leftright(int i, int y, int n, int m)
        {
            //ghost1 turn
            if (ghost1turn)
            {
                if (Supermod1 && !ghost1eaten)
                {
                    if (ghost1.Left < 180 && ghost1.Top == 150 || ghost1.Left > 170 && ghost1.Top == 150) { ghost1speed = 2; Supermod1 = false; v1 = false; ghost1eaten = true; g1ate = false; }
                    else
                    {
                        if (ghost1.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost1.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost1.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost1.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost1 = 0;
                leftghost1 = 0;
                while (!dir1)
                {
                    random1 = rand.Next(1, 5);
                    if (random1 == 1 && !dir1 && random1 != prec1) if (i == 1) { leftghost1 = -ghost1speed; dir1 = true; if (!Supermod1 && ghost1eaten) ghost1.Image = Properties.Resources.rsx; else if (!tresec || g1ate) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if(g1ate) ghost1.Image = Properties.Resources.msx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 2 && !dir1 && random1 != prec1) if (y == 1) { leftghost1 = ghost1speed; dir1 = true; if (!Supermod1 && ghost1eaten) ghost1.Image = Properties.Resources.rdx; else if (!tresec || g1ate) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1ate) ghost1.Image = Properties.Resources.mdx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 3 && !dir1 && random1 != prec1) if (m == 1) { topghost1 = ghost1speed; dir1 = true; if (!Supermod1 && ghost1eaten) ghost1.Image = Properties.Resources.rdown; else if (!tresec || g1ate) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1ate) ghost1.Image = Properties.Resources.mdown; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 4 && !dir1 && random1 != prec1) if (n == 1) { topghost1 = -ghost1speed; dir1 = true; if (!Supermod1 && ghost1eaten ) ghost1.Image = Properties.Resources.rup; else if (!tresec || g1ate) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1ate) ghost1.Image = Properties.Resources.mup1; } else ghost1.Image = Properties.Resources.tempo; }
                }
                if (random1 == 1) prec1 = 2;
                if (random1 == 2) prec1 = 1;
                if (random1 == 3) prec1 = 4;
                if (random1 == 4) prec1 = 3;
                dir1 = false;
            }
            //ghost2 turn
            if (ghost2turn)
            {
                if (Supermod2 && !ghost2eaten)
                {
                    if (ghost2.Left < 180 && ghost2.Top == 150 || ghost2.Left > 170 && ghost2.Top == 150) { ghost2speed = 2; Supermod2 = false; v2 = false; ghost2eaten = true; g2ate = false; }
                    else
                    {
                        if (ghost2.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost2.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost2.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost2.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost2 = 0;
                leftghost2 = 0;
                while (!dir2)
                {
                    random2 = rand.Next(1, 5);
                    if (random2 == 1 && !dir2 && random2 != prec2) if (i == 1) { leftghost2 = -ghost2speed; dir2 = true; if (!Supermod2 && ghost2eaten ) ghost2.Image = Properties.Resources.asx; else if(!tresec || g2ate) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2ate) ghost2.Image = Properties.Resources.msx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 2 && !dir2 && random2 != prec2) if (y == 1) { leftghost2 = ghost2speed; dir2 = true; if (!Supermod2 && ghost2eaten ) ghost2.Image = Properties.Resources.adx; else if (!tresec || g2ate) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2ate) ghost2.Image = Properties.Resources.mdx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 3 && !dir2 && random2 != prec2) if (m == 1) { topghost2 = ghost2speed; dir2 = true; if (!Supermod2 && ghost2eaten ) ghost2.Image = Properties.Resources.adown; else if (!tresec || g2ate) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2ate) ghost2.Image = Properties.Resources.mdown; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 4 && !dir2 && random2 != prec2) if (n == 1) { topghost2 = -ghost2speed; dir2 = true; if (!Supermod2 && ghost2eaten ) ghost2.Image = Properties.Resources.aup; else if (!tresec || g2ate) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2ate) ghost2.Image = Properties.Resources.mup1; } else ghost2.Image = Properties.Resources.tempo; }
                }
                if (random2 == 1) prec2 = 2;
                if (random2 == 2) prec2 = 1;
                if (random2 == 3) prec2 = 4;
                if (random2 == 4) prec2 = 3;
                dir2 = false;
            }
            //ghost3 turn
            if (ghost3turn)
            {
                if (Supermod3 && !ghost3eaten)
                {
                    if (ghost3.Left < 180 && ghost3.Top == 150 || ghost3.Left > 170 && ghost3.Top == 150) { ghost3speed = 2; Supermod3 = false; v3 = false; ghost3eaten = true; g3ate = false; }
                    else
                    {
                        if (ghost3.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost3.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost3.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost3.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost3 = 0;
                leftghost3 = 0;
                while (!dir3)
                {
                    random3 = rand.Next(1, 5);
                    if (random3 == 1 && !dir3 && random3 != prec3) if (i == 1) { leftghost3 = -ghost3speed; dir3 = true; if (!Supermod3 && ghost3eaten) ghost3.Image = Properties.Resources.vsx; else if (!tresec || g3ate) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3ate) ghost3.Image = Properties.Resources.msx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 2 && !dir3 && random3 != prec3) if (y == 1) { leftghost3 = ghost3speed; dir3 = true; if (!Supermod3 && ghost3eaten) ghost3.Image = Properties.Resources.vdx; else if (!tresec || g3ate) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3ate) ghost3.Image = Properties.Resources.mdx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 3 && !dir3 && random3 != prec3) if (m == 1) { topghost3 = ghost3speed; dir3 = true; if (!Supermod3 && ghost3eaten) ghost3.Image = Properties.Resources.vdown; else if(!tresec || g3ate) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3ate) ghost3.Image = Properties.Resources.mdown; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 4 && !dir3 && random3 != prec3) if (n == 1) { topghost3 = -ghost3speed; dir3 = true; if (!Supermod3 && ghost3eaten) ghost3.Image = Properties.Resources.vup; else if (!tresec || g3ate) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3ate) ghost3.Image = Properties.Resources.mup1; } else ghost3.Image = Properties.Resources.tempo; }
                }
                if (random3 == 1) prec3 = 2;
                if (random3 == 2) prec3 = 1;
                if (random3 == 3) prec3 = 4;
                if (random3 == 4) prec3 = 3;
                dir3 = false;
            }
            //ghost4 turn
            if (ghost4turn)
            {
                if (Supermod4 && !ghost4eaten)
                {
                    if (ghost4.Left < 180 && ghost4.Top == 150 || ghost4.Left > 170 && ghost4.Top == 150) { ghost4speed = 2; Supermod4 = false; v4 = false; ghost4eaten = true; g4ate = false; }
                    else
                    {
                        if (ghost4.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost4.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost4.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost4.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost4 = 0;
                leftghost4 = 0;
                while (!dir4)
                {
                    random4 = rand.Next(1, 5);
                    if (random4 == 1 && !dir4 && random4 != prec4) if (i == 1) { leftghost4 = -ghost4speed; dir4 = true; if (!Supermod4 && ghost4eaten) ghost4.Image = Properties.Resources.gsx; else if (!tresec || g4ate) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4ate) ghost4.Image = Properties.Resources.msx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 2 && !dir4 && random4 != prec4) if (y == 1) { leftghost4 = ghost4speed; dir4 = true; if (!Supermod4 && ghost4eaten) ghost4.Image = Properties.Resources.gdx; else if (!tresec || g4ate) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4ate) ghost4.Image = Properties.Resources.mdx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 3 && !dir4 && random4 != prec4) if (m == 1) { topghost4 = ghost4speed; dir4 = true; if (!Supermod4 && ghost4eaten) ghost4.Image = Properties.Resources.gdown; else if (!tresec || g4ate) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4ate) ghost4.Image = Properties.Resources.mdown; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 4 && !dir4 && random4 != prec4) if (n == 1) { topghost4 = -ghost4speed; dir4 = true; if (!Supermod4 && ghost4eaten) ghost4.Image = Properties.Resources.gup; else if (!tresec || g4ate) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4ate) ghost4.Image = Properties.Resources.mup1; } else ghost4.Image = Properties.Resources.tempo; }
                }
                if (random4 == 1) prec4 = 2;
                if (random4 == 2) prec4 = 1;
                if (random4 == 3) prec4 = 4;
                if (random4 == 4) prec4 = 3;
                dir4 = false;
            }
            // pacman turn
            if (pacturn)
            {
                top = 0;
                left = 0;
                if (temp == 1 && i == 1 || temp == 2 && y == 1 || temp == 3 && n == 1 || temp == 4 && m == 1)
                {
                    next = temp;
                }
                if (next == 1 && i == 1)
                {
                    left = -2;
                    pacman.Image = Properties.Resources.pacsx;
                    direzione = next;
                }
                if (next == 2 && y == 1)
                {
                    left = 2;
                    pacman.Image = Properties.Resources.pacdx;
                    direzione = next;
                }
                if (next == 3 && n == 1)
                {
                    top = -2;
                    pacman.Image = Properties.Resources.pacup;
                    direzione = next;
                }
                if (next == 4 && m == 1)
                {
                    top = 2;
                    pacman.Image = Properties.Resources.pacdown;
                    direzione = next;
                }
                if (top == 0 && left == 0)
                {
                    temp = next;
                    next = direzione;
                    if (next == 1) pacman.Image = Properties.Resources._1sx;
                    if (next == 2) pacman.Image = Properties.Resources._1dx;
                    if (next == 3) pacman.Image = Properties.Resources._1up;
                    if (next == 4) pacman.Image = Properties.Resources._1down;
                }
            }
        }


        //actual change direction of pacman
        private void direction()
        {
            pacturn = true;
            a(pacman.Left, pacman.Top);
            pacman.Left += left;
            pacman.Top += top;
        }


        //intersection on the map
        private void a(int left, int top)
        {
            if (pacturn)
            {
                switch (left)
                {
                    case 174:
                        if (top == 148) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 24:
                        if (top == 364) { leftright(0, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 292) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 76) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 48:
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        if (top == 292) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 84:
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(0, 1, 1, 1); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 120:
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 220) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 148) { leftright(0, 1, 0, 1); break; }
                        if (top == 184) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 156:
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 192:
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(0, 1, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 228:
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 220) { leftright(1, 0, 1, 1); break; }
                        if (top == 184) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 148) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 264:
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 324:
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 0, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 76) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 300:
                        if (top == 292) { leftright(0, 1, 0, 1); break; }
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 374:
                        if (top == 184) { transport(0, 1); break; }
                        break;
                    case -26:
                        if (top == 184) { transport(1, 0); break; }
                        break;
                }
            }
            else
            {
                switch (left)
                {
                    case 176:
                        if (top == 150) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 26:
                        if (top == 366) { leftright(0, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 294) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 78) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 50:
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        if (top == 294) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 86:
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(0, 1, 1, 1); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 122:
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 222) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 150) { leftright(0, 1, 0, 1); break; }
                        if (top == 186) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 158:
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 194:
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(0, 1, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 230:
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 222) { leftright(1, 0, 1, 1); break; }
                        if (top == 186) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 150) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 266:
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 326:
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 0, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 78) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 302:
                        if (top == 294) { leftright(0, 1, 0, 1); break; }
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 376:
                        if (top == 186) { transport(0, 1); break; }
                        break;
                    case -28:
                        if (top == 186) { transport(1, 0); break; }
                        break;
                }
            }
            pacturn = false;
            ghost1turn = false;
            ghost2turn = false;
            ghost3turn = false;
            ghost4turn = false;
        }


        //character teleportation
        private void transport(int i, int n)
        {
            if (pacturn)
            {
                if (i == 0) pacman.Left = -26;
                if (n == 0) pacman.Left = 374;
            }
            if (ghost1turn)
            {
                if (i == 0) ghost1.Left = -26;
                if (n == 0) ghost1.Left = 374;
            }
            if (ghost2turn)
            {
                if (i == 0) ghost2.Left = -26;
                if (n == 0) ghost2.Left = 374;
            }
            if (ghost3turn)
            {
                if (i == 0) ghost3.Left = -26;
                if (n == 0) ghost3.Left = 374;
            }
            if (ghost4turn)
            {
                if (i == 0) ghost4.Left = -26;
                if (n == 0) ghost4.Left = 374;
            }
        }


        //actual change of the position of the ghosts
        private void ghost()
        {
            if (ghost1.Enabled == true)
            {
                ghost1.Left += leftghost1;
                ghost1.Top += topghost1;
                ghost1turn = true;
                a(ghost1.Left, ghost1.Top);
            }
            if (ghost2.Enabled == true)
            {
                ghost2.Left += leftghost2;
                ghost2.Top += topghost2;
                ghost2turn = true;
                a(ghost2.Left, ghost2.Top);
            }
            if (ghost3.Enabled == true)
            {
                ghost3.Left += leftghost3;
                ghost3.Top += topghost3;
                ghost3turn = true;
                a(ghost3.Left, ghost3.Top);
            }
            if (ghost4.Enabled == true)
            {
                ghost4.Left += leftghost4;
                ghost4.Top += topghost4;
                ghost4turn = true;
                a(ghost4.Left, ghost4.Top);
            }
        }
    }
}
