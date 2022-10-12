rakendusse kavandatud täiendused

lisa administraatori vorm
lisage muudatuste lisamine ja kustutamine alusest läbi admini vormi

 Form3: - math quiz
Timer_Tick() - taimer sekundites
check() - kontrollib vastuseid *jagamisel ümardatud
StartQuz() - alustab viktoriini (seadistab taimeri ja määrab küsimused juhuslikult)
 Form2: - picture view
Cb_CheckedChanged - venitab pilti
btn_Click - oleneb tekstist täidab teatud funktsioone (muudab taustavärvi, näitab pilti, eemaldab pildi, sulgeb vormi)
 Form4: - match game
TimeLeft_Tick - arvutab, kui kaua mäng sul aega võttis
Lbl_Click - näitab ja kontrollib valitud märke (identsed või mitte)
AssignIconsToSquares - randomiseerib mängus olevad märgid ja peidab need
CheckForWinner() - kontrollib, kas olete võitnud
  ja pärast kontrolli, kas olete registreeritud kasutaja või mitte
   code: 
     if (kas!=null)
            {
                MessageBox.Show($"Sa sobitasid kõik ikoonid!{kas.nimi} sul on aeg: {time} sekondit", "palju õnne");
            }
            else
            {
                MessageBox.Show($"Sa sobitasid kõik ikoonid! Sul on aeg: {time} sekondit", "palju õnne");
            }
   ka pärast seda, kui see lisab teie kirje tabelisse ja registreerimisel sisestab kasutaja väljale teie nime ja posti või kirjutab teid külalisena
    code:
     ApplicationContext con = new ApplicationContext();
            rekordit rek = new rekordit();
            rek.mang = this.Text;
            rek.rekord = $"{time} sekondit";
            if (kas != null)
            {
                rek.kasutaja = kas.nimi + "-" + kas.email;
            }
            else
            {
                rek.kasutaja = "külaline";
            }

 regist - registrerimine vorm
Reg_Click(object sender, EventArgs e) - lisa uus konto andmebaasisse
 code:
  ApplicationContext con = new ApplicationContext();
            kasutaja uss_konto = new kasutaja();
            uss_konto.nimi=username.Text.Trim();
            uss_konto.salasona=password.Text.Trim();
            uss_konto.sugu = sugu;
            uss_konto.vanus = (int)dtp.Value;
            uss_konto.email=email.Text.Trim();
            uss_konto.avatar = avatar;
            uss_konto.isadmin = 0;
            con.kasutajad1.Add(uss_konto);
            con.SaveChangesAsync();
  login - login vorm
 Log_Click(object sender, EventArgs e) - otsin andmebaasist kontot
  code:
   ApplicationContext con = new ApplicationContext();
            foreach (kasutaja kas in con.kasutajad1)
            {
                if (kas.email == username.Text.Trim() && kas.salasona==password.Text.Trim())
                {
                    this.Close();
                    this.kas = kas;
                    Form1 w = new Form1(kas);
                    w.Show();
                }
                else
                {
                    MessageBox.Show("Kasutaja ei leinud", "error");
                }
            }
 rekordit.cs - rekordite tabeliklass
 kasutaja.cs - kasutaja tabeli klass
 
 ApplicationContext.cs - andmebaasi kontekstiklass
  public ApplicationContext() : base("kasutajad") //kontrollib, kas andmebaas on loodud ja loob uuesti, kui lisatakse uusi tabeleid *mineviku andmebaas andmeid ei salvestata
        {
            if (Database.Exists("kasutajad"))
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationContext>());
            }
        }
  public DbSet<kasutaja> kasutajad1{get; set;} - kasutajad tabel
  public DbSet<rekordit> rekordit1 { get; set; } - rekordi tabel
