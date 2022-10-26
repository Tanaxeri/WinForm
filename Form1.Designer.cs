namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nev = new System.Windows.Forms.Label();
            this.nevmez = new System.Windows.Forms.TextBox();
            this.UdvGomb = new System.Windows.Forms.Button();
            this.Szuldat = new System.Windows.Forms.Label();
            this.Szulmez = new System.Windows.Forms.DateTimePicker();
            this.azonmez = new System.Windows.Forms.NumericUpDown();
            this.Varosmez = new System.Windows.Forms.ComboBox();
            this.Azono = new System.Windows.Forms.Label();
            this.Varos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.angolgom = new System.Windows.Forms.RadioButton();
            this.nemegomb = new System.Windows.Forms.RadioButton();
            this.franciagomb = new System.Windows.Forms.RadioButton();
            this.olaszgomb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.azonmez)).BeginInit();
            this.SuspendLayout();
            // 
            // Nev
            // 
            this.Nev.AutoSize = true;
            this.Nev.Location = new System.Drawing.Point(18, 13);
            this.Nev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(37, 19);
            this.Nev.TabIndex = 0;
            this.Nev.Text = "Név";
            // 
            // nevmez
            // 
            this.nevmez.Location = new System.Drawing.Point(68, 13);
            this.nevmez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nevmez.Name = "nevmez";
            this.nevmez.Size = new System.Drawing.Size(148, 26);
            this.nevmez.TabIndex = 1;
            // 
            // UdvGomb
            // 
            this.UdvGomb.Location = new System.Drawing.Point(992, 583);
            this.UdvGomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UdvGomb.Name = "UdvGomb";
            this.UdvGomb.Size = new System.Drawing.Size(190, 57);
            this.UdvGomb.TabIndex = 2;
            this.UdvGomb.Text = "ÜdvGomb";
            this.UdvGomb.UseVisualStyleBackColor = true;
            this.UdvGomb.Click += new System.EventHandler(this.UdvGomb_Click);
            // 
            // Szuldat
            // 
            this.Szuldat.AutoSize = true;
            this.Szuldat.Location = new System.Drawing.Point(12, 63);
            this.Szuldat.Name = "Szuldat";
            this.Szuldat.Size = new System.Drawing.Size(117, 19);
            this.Szuldat.TabIndex = 3;
            this.Szuldat.Text = "Születési Dátum";
            // 
            // Szulmez
            // 
            this.Szulmez.CustomFormat = "\"\"";
            this.Szulmez.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Szulmez.Location = new System.Drawing.Point(135, 63);
            this.Szulmez.MaxDate = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            this.Szulmez.Name = "Szulmez";
            this.Szulmez.Size = new System.Drawing.Size(200, 26);
            this.Szulmez.TabIndex = 4;
            this.Szulmez.Value = new System.DateTime(2022, 10, 19, 0, 0, 0, 0);
            // 
            // azonmez
            // 
            this.azonmez.Location = new System.Drawing.Point(98, 95);
            this.azonmez.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.azonmez.Name = "azonmez";
            this.azonmez.Size = new System.Drawing.Size(214, 26);
            this.azonmez.TabIndex = 5;
            // 
            // Varosmez
            // 
            this.Varosmez.FormattingEnabled = true;
            this.Varosmez.Items.AddRange(new object[] {
            "Aba",
            "Abádszalók",
            "Abaújszántó",
            "Abony",
            "Ács",
            "Adony",
            "Ajak",
            "Ajka",
            "Albertirsa",
            "Alsózsolca",
            "Aszód",
            "Bábolna",
            "Bácsalmás",
            "Badacsonytomaj",
            "Baja",
            "Baktalórántháza",
            "Balassagyarmat",
            "Balatonalmádi",
            "Balatonboglár",
            "Balatonföldvár",
            "Balatonfüred",
            "Balatonfűzfő",
            "Balatonkenese",
            "Balatonlelle",
            "Balkány",
            "Balmazújváros",
            "Barcs",
            "Bátaszék",
            "Bátonyterenye",
            "Battonya",
            "Békés",
            "Békéscsaba",
            "Bélapátfalva",
            "Beled",
            "Berettyóújfalu",
            "Berhida",
            "Besenyszög",
            "Biatorbágy",
            "Bicske",
            "Biharkeresztes",
            "Bodajk",
            "Bóly",
            "Bonyhád",
            "Borsodnádasd",
            "Budakalász",
            "Budakeszi",
            "Budaörs",
            "Budapest",
            "Bük",
            "Cegléd",
            "Celldömölk",
            "Cigánd",
            "Csákvár",
            "Csanádpalota",
            "Csenger",
            "Csepreg",
            "Csongrád",
            "Csorna",
            "Csorvás",
            "Csurgó",
            "Dabas",
            "Debrecen",
            "Demecser",
            "Derecske",
            "Dévaványa",
            "Devecser",
            "Diósd",
            "Dombóvár",
            "Dombrád",
            "Dorog",
            "Dunaföldvár",
            "Dunaharaszti",
            "Dunakeszi",
            "Dunaújváros",
            "Dunavarsány",
            "Dunavecse",
            "Edelény",
            "Eger",
            "Elek",
            "Emőd",
            "Encs",
            "Enying",
            "Ercsi",
            "Érd",
            "Esztergom",
            "Fegyvernek",
            "Fehérgyarmat",
            "Felsőzsolca",
            "Fertőd",
            "Fertőszentmiklós",
            "Fonyód",
            "Fót",
            "Füzesabony",
            "Füzesgyarmat",
            "Gárdony",
            "Göd",
            "Gödöllő",
            "Gönc",
            "Gyál",
            "Gyomaendrőd",
            "Gyömrő",
            "Gyöngyös",
            "Gyöngyöspata",
            "Gyönk",
            "Győr",
            "Gyula",
            "Hajdúböszörmény",
            "Hajdúdorog",
            "Hajdúhadház",
            "Hajdúnánás",
            "Hajdúsámson",
            "Hajdúszoboszló",
            "Hajós",
            "Halásztelek",
            "Harkány",
            "Hatvan",
            "Herend",
            "Heves",
            "Hévíz",
            "Hódmezővásárhely",
            "Ibrány",
            "Igal",
            "Isaszeg",
            "Izsák",
            "Jánoshalma",
            "Jánosháza",
            "Jánossomorja",
            "Jászapáti",
            "Jászárokszállás",
            "Jászberény",
            "Jászfényszaru",
            "Jászkisér",
            "Kaba",
            "Kadarkút",
            "Kalocsa",
            "Kaposvár",
            "Kapuvár",
            "Karcag",
            "Kazincbarcika",
            "Kecel",
            "Kecskemét",
            "Kemecse",
            "Kenderes",
            "Kerekegyháza",
            "Kerepes",
            "Keszthely",
            "Kisbér",
            "Kisköre",
            "Kiskőrös",
            "Kiskunfélegyháza",
            "Kiskunhalas",
            "Kiskunlacháza",
            "Kiskunmajsa",
            "Kistarcsa",
            "Kistelek",
            "Kisújszállás",
            "Kisvárda",
            "Komádi",
            "Komárom",
            "Komló",
            "Kondoros",
            "Kozármisleny",
            "Körmend",
            "Körösladány",
            "Kőszeg",
            "Kunhegyes",
            "Kunszentmárton",
            "Kunszentmiklós",
            "Lábatlan",
            "Lajosmizse",
            "Lébény",
            "Lengyeltóti",
            "Lenti",
            "Létavértes",
            "Letenye",
            "Lőrinci",
            "Maglód",
            "Mágocs",
            "Makó",
            "Mándok",
            "Marcali",
            "Máriapócs",
            "Martfű",
            "Martonvásár",
            "Mátészalka",
            "Medgyesegyháza",
            "Mélykút",
            "Mezőberény",
            "Mezőcsát",
            "Mezőhegyes",
            "Mezőkeresztes",
            "Mezőkovácsháza",
            "Mezőkövesd",
            "Mezőtúr",
            "Mindszent",
            "Miskolc",
            "Mohács",
            "Monor",
            "Mór",
            "Mórahalom",
            "Mosonmagyaróvár",
            "Nádudvar",
            "Nagyatád",
            "Nagybajom",
            "Nagyecsed",
            "Nagyhalász",
            "Nagykálló",
            "Nagykanizsa",
            "Nagykáta",
            "Nagykőrös",
            "Nagymányok",
            "Nagymaros",
            "Nyékládháza",
            "Nyergesújfalu",
            "Nyíradony",
            "Nyírbátor",
            "Nyírbogát",
            "Nyíregyháza",
            "Nyírlugos",
            "Nyírmada",
            "Nyírtelek",
            "Ócsa",
            "Onga",
            "Orosháza",
            "Oroszlány",
            "Ózd",
            "Őrbottyán",
            "Őriszentpéter",
            "Örkény",
            "Pacsa",
            "Paks",
            "Pálháza",
            "Pannonhalma",
            "Pápa",
            "Pásztó",
            "Pécel",
            "Pécs",
            "Pécsvárad",
            "Pétervására",
            "Pilis",
            "Piliscsaba",
            "Pilisvörösvár",
            "Polgár",
            "Polgárdi",
            "Pomáz",
            "Pusztaszabolcs",
            "Putnok",
            "Püspökladány",
            "Rácalmás",
            "Ráckeve",
            "Rakamaz",
            "Rákóczifalva",
            "Répcelak",
            "Rétság",
            "Rudabánya",
            "Sajóbábony",
            "Sajószentpéter",
            "Salgótarján",
            "Sándorfalva",
            "Sárbogárd",
            "Sarkad",
            "Sárospatak",
            "Sárvár",
            "Sásd",
            "Sátoraljaújhely",
            "Sellye",
            "Siklós",
            "Simontornya",
            "Siófok",
            "Solt",
            "Soltvadkert",
            "Sopron",
            "Sülysáp",
            "Sümeg",
            "Szabadszállás",
            "Szarvas",
            "Százhalombatta",
            "Szécsény",
            "Szeged",
            "Szeghalom",
            "Székesfehérvár",
            "Szekszárd",
            "Szendrő",
            "Szentendre",
            "Szentes",
            "Szentgotthárd",
            "Szentlőrinc",
            "Szerencs",
            "Szigethalom",
            "Szigetszentmiklós",
            "Szigetvár",
            "Szikszó",
            "Szob",
            "Szolnok",
            "Szombathely",
            "Tab",
            "Tamási",
            "Tápiószele",
            "Tapolca",
            "Tát",
            "Tata",
            "Tatabánya",
            "Téglás",
            "Tét",
            "Tiszacsege",
            "Tiszaföldvár",
            "Tiszafüred",
            "Tiszakécske",
            "Tiszalök",
            "Tiszaújváros",
            "Tiszavasvári",
            "Tokaj",
            "Tolna",
            "Tompa",
            "Tótkomlós",
            "Tököl",
            "Törökbálint",
            "Törökszentmiklós",
            "Tura",
            "Túrkeve",
            "Újfehértó",
            "Újhartyán",
            "Újkígyós",
            "Újszász",
            "Üllő",
            "Vác",
            "Vaja",
            "Vámospércs",
            "Várpalota",
            "Vásárosnamény",
            "Vasvár",
            "Vecsés",
            "Velence",
            "Vép",
            "Veresegyház",
            "Verpelét",
            "Veszprém",
            "Vésztő",
            "Villány",
            "Visegrád",
            "Záhony",
            "Zalaegerszeg",
            "Zalakaros",
            "Zalalövő",
            "Zalaszentgrót",
            "Zamárdi",
            "Zirc",
            "Zsámbék",
            ""});
            this.Varosmez.Location = new System.Drawing.Point(396, 63);
            this.Varosmez.Name = "Varosmez";
            this.Varosmez.Size = new System.Drawing.Size(276, 27);
            this.Varosmez.TabIndex = 7;
            // 
            // Azono
            // 
            this.Azono.AutoSize = true;
            this.Azono.Location = new System.Drawing.Point(18, 95);
            this.Azono.Name = "Azono";
            this.Azono.Size = new System.Drawing.Size(74, 19);
            this.Azono.TabIndex = 10;
            this.Azono.Text = "Azonosító";
            // 
            // Varos
            // 
            this.Varos.AutoSize = true;
            this.Varos.Location = new System.Drawing.Point(341, 69);
            this.Varos.Name = "Varos";
            this.Varos.Size = new System.Drawing.Size(49, 19);
            this.Varos.TabIndex = 11;
            this.Varos.Text = "Város";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nyelv";
            // 
            // angolgom
            // 
            this.angolgom.AutoSize = true;
            this.angolgom.Location = new System.Drawing.Point(73, 135);
            this.angolgom.Name = "angolgom";
            this.angolgom.Size = new System.Drawing.Size(66, 23);
            this.angolgom.TabIndex = 13;
            this.angolgom.TabStop = true;
            this.angolgom.Text = "Angol";
            this.angolgom.UseVisualStyleBackColor = true;
            // 
            // nemegomb
            // 
            this.nemegomb.AutoSize = true;
            this.nemegomb.Location = new System.Drawing.Point(73, 164);
            this.nemegomb.Name = "nemegomb";
            this.nemegomb.Size = new System.Drawing.Size(72, 23);
            this.nemegomb.TabIndex = 14;
            this.nemegomb.TabStop = true;
            this.nemegomb.Text = "Német";
            this.nemegomb.UseVisualStyleBackColor = true;
            // 
            // franciagomb
            // 
            this.franciagomb.AutoSize = true;
            this.franciagomb.Location = new System.Drawing.Point(73, 193);
            this.franciagomb.Name = "franciagomb";
            this.franciagomb.Size = new System.Drawing.Size(77, 23);
            this.franciagomb.TabIndex = 15;
            this.franciagomb.TabStop = true;
            this.franciagomb.Text = "Francia";
            this.franciagomb.UseVisualStyleBackColor = true;
            // 
            // olaszgomb
            // 
            this.olaszgomb.AutoSize = true;
            this.olaszgomb.Location = new System.Drawing.Point(73, 222);
            this.olaszgomb.Name = "olaszgomb";
            this.olaszgomb.Size = new System.Drawing.Size(64, 23);
            this.olaszgomb.TabIndex = 16;
            this.olaszgomb.TabStop = true;
            this.olaszgomb.Text = "Olasz";
            this.olaszgomb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.olaszgomb);
            this.Controls.Add(this.franciagomb);
            this.Controls.Add(this.nemegomb);
            this.Controls.Add(this.angolgom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Varos);
            this.Controls.Add(this.Azono);
            this.Controls.Add(this.Varosmez);
            this.Controls.Add(this.azonmez);
            this.Controls.Add(this.Szulmez);
            this.Controls.Add(this.Szuldat);
            this.Controls.Add(this.UdvGomb);
            this.Controls.Add(this.nevmez);
            this.Controls.Add(this.Nev);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.azonmez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nev;
        private System.Windows.Forms.TextBox nevmez;
        private System.Windows.Forms.Button UdvGomb;
        private System.Windows.Forms.Label Szuldat;
        private System.Windows.Forms.DateTimePicker Szulmez;
        private System.Windows.Forms.NumericUpDown azonmez;
        private System.Windows.Forms.ComboBox Varosmez;
        private System.Windows.Forms.Label Azono;
        private System.Windows.Forms.Label Varos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton angolgom;
        private System.Windows.Forms.RadioButton nemegomb;
        private System.Windows.Forms.RadioButton franciagomb;
        private System.Windows.Forms.RadioButton olaszgomb;
    }
}

