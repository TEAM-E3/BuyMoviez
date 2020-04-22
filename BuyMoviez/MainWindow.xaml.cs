using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Globalization;

namespace BuyMoviez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        List<Movie> allMovies = new List<Movie>();
        List<Movie> selectedMovies = new List<Movie>();
        List<Movie> filteredMovies = new List<Movie>();
        decimal totalPrice = 0;


    public MainWindow()
        {
            InitializeComponent();
            this.FontFamily = new FontFamily("Segoe Script");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
            //All Action Movies
            Movie a1 = new Movie()
            {
                Name = "Breaking Bad",
                Director =  " Vince Gilligan",
                Price =  30m,
                Description = "Premise. Set in Albuquerque, New Mexico between 2008 and 2010, Breaking Bad follows Walter White, a meek high school science teacher who transforms into a ruthless player in the local methamphetamine drug trade, driven by a desire to provide for his family after being diagnosed with terminal lung cancer. ",
                MovieRelease = new DateTime(2008, 01, 20),
                MovieGenre = MovieType.Action,
                Image = "bb"
            };

            Movie a2 = new Movie()
            {
                Name = "12 Strong",
                Director = " Nikolai Fugslig",
                Price = 25m,
                Description = "In the wake of the September 11 attacks, Captain Mitch Nelson leads a US Special Forces team into Afghanistan for an extremely dangerous mission. Once there, the soldiers develop an uneasy partnership with the Northern Alliance to take down the Taliban and its al-Qaida allies. Outgunned and outnumbered, Nelson and his forces face overwhelming odds in a fight against a ruthless enemy that takes no prisoners. ",
                MovieRelease = new DateTime(2018, 05, 15),
                MovieGenre = MovieType.Action,
                Image = "12strong"
            };

            Movie a3 = new Movie()
            {
                Name = "Divergent",
                Director = " Neil Burger ",
                Price = 15m,
                Description = "Tris Prior Shailene Woodley lives in a futuristic world in which society is divided into five factions. As each person enters adulthood, he or she must choose a faction and commit to it for life. Tris chooses Dauntless  those who pursue bravery above all else. However, her initiation leads to the discovery that she is a Divergent and will never be able to fit into just one faction. Warned that she must conceal her status, Tris uncovers a looming war which threatens everyone she loves. ",
                MovieRelease = new DateTime(2014, 02, 28),
                MovieGenre = MovieType.Action,
                Image = "divergent"
            };

            Movie a4 = new Movie()
            {
                Name = "Resident Evil AfterLife",
                Director = " Paul Anderson",
                Price = 15m,
                Description = "In a world overrun with the walking dead, Alice (Milla Jovovich) continues her battle against Umbrella Corp., rounding up survivors along the way. Joined by an old friend, Alice and her group set out for a rumored safe haven in Los Angeles. Instead of sanctuary, they find the city overrun with zombies, and a trap about to spring. ",
                MovieRelease = new DateTime(2010, 10, 10),
                MovieGenre = MovieType.Action,
                Image = "residentevil"
            };

            Movie a5 = new Movie()
            {
                Name = "Boyka Undisputed",
                Director = " Todd Chapankov",
                Price = 15.50m,
                Description = "Boyka (Scott Adkins) accidentally kills an opponent in the ring, forcing him to question everything he's worked for. When he finds out his opponent's widow is in trouble, he becomes her champion in a series of seemingly impossible fights. ",
                MovieRelease = new DateTime(2016, 07, 20),
                MovieGenre = MovieType.Action,
                Image = "boyka"
            };


            //All Comedy movies
            Movie c1 = new Movie()
            {
                Name = "Hangover 3 ",
                Director = "Todd Phillips",
                Price = 10m,
                Description = "It's been two years since the gang known as the Wolfpack narrowly escaped disaster in Bangkok. Now, Phil (Bradley Cooper), Stu (Ed Helms) and Doug (Justin Bartha) have happy lives at home -- but Alan (Zach Galifianakis) doesn't. Still lacking contentment and a sense of purpose, Alan has gone off his meds and surrendered to his natural impulses. ",
                MovieRelease = new DateTime(2013, 05, 20),
                MovieGenre = MovieType.Comedy,
                Image = "hangover"
            };

            Movie c2 = new Movie()
            {
                Name = "Murder Mystery",
                Director = "Kyle Newacheck",
                Price = 20m,
                Description = "A New York cop and his wife go on a European vacation to reinvigorate the spark in their marriage. A chance encounter leads to them being framed for the murder of an elderly billionaire. ",
                MovieRelease = new DateTime(2019, 04, 17),
                MovieGenre = MovieType.Comedy,
                Image = "murdermystery"
            };

            Movie c3 = new Movie()
            {
                Name = "The Interview ",
                Director = "Evan Goldberg",
                Price = 12.50m,
                Description = "As Dave and Aaron prepare for their journey to Pyongyang, the CIA steps in, recruits them, and assigns them an incredible mission: Assassinate the dictator. ",
                MovieRelease = new DateTime(2014, 09, 12),
                MovieGenre = MovieType.Comedy,
                Image = "theinterview"
            };

            Movie c4 = new Movie()
            {
                Name = "JackAss 3 ",
                Director = "Jedd Tremaine",
                Price = 10m,
                Description = "Johnny Knoxville, Bam Margera, Steve-O, Wee Man and the rest of their fearless and foolhardy friends take part in another round of outrageous pranks and stunts. ",
                MovieRelease = new DateTime(2010, 02, 11),
                MovieGenre = MovieType.Comedy,
                Image = "jackass"
            };

            Movie c5 = new Movie()
            {
                Name = "Pineapple Express ",
                Director = "David Gordon Green",
                Price = 12.50m,
                Description = "Stoner Dale Denton's (Seth Rogen) enjoyment of a rare strain of marijuana may prove fatal when he drops his roach in a panic after witnessing a murder. Upon learning that the fancy weed can be traced back to them, Dale and his dealer (James Franco) go on the lam, with a dangerous drug lord (Gary Cole) and crooked cop (Rosie Perez) hot on their heels. ",
                MovieRelease = new DateTime(2008, 11, 30),
                MovieGenre = MovieType.Comedy,
                Image = "pineappleexpress"
            };


            //All Horror movies

            Movie h1 = new Movie()
            {
                Name = "Sinister",
                Director = " Ciaran Foy",
                Price = 20m,
                Description = "True-crime writer Ellison Oswald (Ethan Hawke) is in a slump; he hasn't had a best seller in more than 10 years and is becoming increasingly desperate for a hit. So, when he discovers the existence of a snuff film showing the deaths of a family, he vows to solve the mystery. ",
                MovieRelease = new DateTime(2015, 08, 21),
                MovieGenre = MovieType.Horror,
                Image = "sinister"
            };

            Movie h2 = new Movie()
            {
                Name = "The Conjuring 2",
                Director = " James Wan",
                Price = 19.50m,
                Description = "A single mother seeks the help of occult investigators Ed and Lorraine Warren when she and her children witness strange, paranormal events in their house. ",
                MovieRelease = new DateTime(2016, 04, 27),
                MovieGenre = MovieType.Horror,
                Image = "theconjuring"
            };

            Movie h3 = new Movie()
            {
                Name = "The purge",
                Director = " James DeMonaco ",
                Price = 7.50m,
                Description = "In an America ravaged by crime and overcrowded prisons, the government sanctions an annual 12-hour period during which all criminal activity -- including murder -- is legal. James Sandin (Ethan Hawke) and his family face the ultimate test when an intruder drags the vicious outside world into their home.",
                MovieRelease = new DateTime(2013, 12, 02),
                MovieGenre = MovieType.Horror,
                Image = "thepurge"
            };

            Movie h4 = new Movie()
            {
                Name = "28 Days Later",
                Director = "Danny Boyle ",
                Price = 15m,
                Description = "A group of misguided animal rights activists free a caged chimp infected with the Rage virus from a medical research lab. When London bike courier Jim (Cillian Murphy) wakes up from a coma a month after, he finds his city all but deserted.",
                MovieRelease = new DateTime(2015, 08, 21),
                MovieGenre = MovieType.Horror,
                Image = "28days"
            };

            Movie h5 = new Movie()
            {
                Name = "A Quiet Place",
                Director = " John Krasinski",
                Price = 25m,
                Description = "f they hear you, they hunt you. A family must live in silence to avoid mysterious creatures that hunt by sound. Knowing that even the slightest whisper or footstep can bring death, Evelyn and Lee are determined to find a way to protect their children while desperately searching for a way to fight back. ",
                MovieRelease = new DateTime(2018, 09, 27),
                MovieGenre = MovieType.Horror,
                Image = "quietplace"
            };



            //All SciFi movies
            Movie s1 = new Movie()
            {
                Name = "Originals",
                Director = " Joseph Morgan",
                Price = 30m,
                Description = "A spin-off from The Vampire Diaries and set in New Orleans, The Originals centers on the Mikaelson siblings, otherwise known as the world's original vampires: Klaus (Joseph Morgan), Elijah (Daniel Gillies), and Rebekah (Claire Holt). ... Every King needs an heir says Klaus, accepting the unborn child.",
                MovieRelease = new DateTime(2018, 08, 01),
                MovieGenre = MovieType.SciFi,
                Image = "originals"
            };

            Movie s2 = new Movie()
            {
                Name = "Avengers Endgame",
                Director = " Joe Russo",
                Price = 45m,
                Description = "Adrift in space with no food or water, Tony Stark sends a message to Pepper Potts as his oxygen supply starts to dwindle. Meanwhile, the remaining Avengers -- Thor, Black Widow, Captain America and Bruce Banner -- must figure out a way to bring back their vanquished allies for an epic showdown with Thanos -- the evil demigod who decimated the planet and the universe.",
                MovieRelease = new DateTime(2019, 04, 25),
                MovieGenre = MovieType.SciFi,
                Image = "endgame"
            };

            Movie s3 = new Movie()
            {
                Name = "Star Wars",
                Director = " J.J. Abrams",
                Price = 20m,
                Description = "When it's discovered that the evil Emperor Palpatine did not die at the hands of Darth Vader, the rebels must race against the clock to find out his whereabouts. Finn and Poe lead the Resistance to put a stop to the First Order's plans to form a new Empire, while Rey anticipates her inevitable confrontation with Kylo Ren.",
                MovieRelease = new DateTime(2019, 12, 19),
                MovieGenre = MovieType.SciFi,
                Image = "starwars"
            };

            Movie s4 = new Movie()
            {
                Name = "The Martian",
                Director = " Ridley Scott",
                Price = 12.50m,
                Description = "When astronauts blast off from the planet Mars, they leave behind Mark Watney (Matt Damon), presumed dead after a fierce storm. With only a meager amount of supplies, the stranded visitor must utilize his wits and spirit to find a way to survive on the hostile planet. ",
                MovieRelease = new DateTime(2015, 10, 11),
                MovieGenre = MovieType.SciFi,
                Image = "martian"
            };

            Movie s5 = new Movie()
            {
                Name = "InterStellar",
                Director = " Christopher Nolan",
                Price = 7.50m,
                Description = "n Earth's future, a global crop blight and second Dust Bowl are slowly rendering the planet uninhabitable. Professor Brand (Michael Caine), a brilliant NASA physicist, is working on plans to save mankind by transporting Earth's population to a new home via a wormhole. ",
                MovieRelease = new DateTime(2014, 11, 7),
                MovieGenre = MovieType.SciFi,
                Image = "interstellar"
            };


            //All Documentaries
            Movie d1 = new Movie()
            {
                Name = "ICARUS",
                Director = " Bryan Fogel",
                Price = 5m,
                Description = "When filmmaker Bryan Fogel sets out to uncover the truth about doping in sports, a chance meeting with a Russian scientist transforms his story from a personal experiment into a geopolitical thriller. Dirty urine, unexplained death and Olympic gold are all part of the exposure of the biggest scandal in sports history. ",
                MovieRelease = new DateTime(2017, 01, 09),
                MovieGenre = MovieType.Documentaries,
                Image = "icarusnew"
            };

            Movie d2 = new Movie()
            {
                Name = "Blackfish ",
                Director = " Gabriella Cowpertwaite",
                Price = 5m,
                Description = "The story of Tilikum, a captive killer whale that has taken the lives of several people, underscores problems within the sea-park industry, man's relationship to nature, and how little has been learned about these highly intelligent mammals. ",
                MovieRelease = new DateTime(2013, 07, 19),
                MovieGenre = MovieType.Documentaries,
                Image = "blackfish"
            };


            Movie d3 = new Movie()
            {
                Name = "13th",
                Director = " Ava DuVernay",
                Price = 5m,
                Description = "Filmmaker Ava DuVernay explores the history of racial inequality in the United States, focusing on the fact that the nation's prisons are disproportionately filled with African-Americans.",
                MovieRelease = new DateTime(2016, 11, 07),
                MovieGenre = MovieType.Documentaries,
                Image = "13th"
            };


            Movie d4 = new Movie()
            {
                Name = "The Great Hack",
                Director = " Karim Amer ",
                Price = 5m,
                Description = "Exploring how a data company named Cambridge Analytica came to symbolise the dark side of social media in the wake of the 2016 U.S. presidential election, as uncovered by journalist Carole Cadwalladr.",
                MovieRelease = new DateTime(2019, 01, 26),
                MovieGenre = MovieType.Documentaries,
                Image = "thegreathack"
            };


            Movie d5 = new Movie()
            {
                Name = "The Look of Silence",
                Director = " Joshua Oppenheimer",
                Price = 5m,
                Description = "The documentary focuses on an optometrist named Adi, who decides to break the silence of submission by doing something unthinkable, in a society where the murderers and the genocidal remain in power. ",
                MovieRelease = new DateTime(2017, 01, 09),
                MovieGenre = MovieType.Documentaries,
                Image = "silence"
            };



            //this will add all the movies to the list
            //Action.Add
            allMovies.Add(a1);
            allMovies.Add(a2);
            allMovies.Add(a3);
            allMovies.Add(a4);
            allMovies.Add(a5);
            //Comedies.Add
            allMovies.Add(c1);
            allMovies.Add(c2);
            allMovies.Add(c3);
            allMovies.Add(c4);
            allMovies.Add(c5);
            //SciFi.Add
            allMovies.Add(s1);
            allMovies.Add(s2);
            allMovies.Add(s3);
            allMovies.Add(s4);
            allMovies.Add(s5);
            //Horror.Add
            allMovies.Add(h1);
            allMovies.Add(h2);
            allMovies.Add(h3);
            allMovies.Add(h4);
            allMovies.Add(h5);
            //Documentary.Add
            allMovies.Add(d1);
            allMovies.Add(d2);
            allMovies.Add(d3);
            allMovies.Add(d4);
            allMovies.Add(d5);

            //display the movies that i added to the list above
            listboxChooseMovie.ItemsSource = allMovies;
            listboxChosen.ItemsSource = selectedMovies;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (listboxChooseMovie.SelectedItem is Movie selected)

            {
                //this will now choose the movies and put it into the other listbox
                allMovies.Remove(selected);
                selectedMovies.Add(selected);

                //add the totat price
                totalPrice += selected.Price;
                txtblkTotalPrice.Text = totalPrice.ToString("$0.00");


                //refreshes the screen for updates
                RefreshScreen();

            }
            else
            {
                MessageBox.Show("Select a Movie you want to get");
            }
        }

        //refresh screen method
        private void RefreshScreen()
        {
            listboxChooseMovie.ItemsSource = null;
            listboxChosen.ItemsSource = null;

            listboxChooseMovie.ItemsSource = allMovies;
            listboxChosen.ItemsSource = selectedMovies;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Movie selected = listboxChosen.SelectedItem as Movie;

            if (selected != null)
            {

                allMovies.Add(selected);
                selectedMovies.Remove(selected);

                //removes the price when th movie is removed
                totalPrice -= selected.Price;
                txtblkTotalPrice.Text = totalPrice.ToString();
                

                RefreshScreen();
            }

            else
            {
                MessageBox.Show("You have to select a movie to remove");
            }

        }

        //Code for filtering the radio buttons
        private void radioAll_Checked(object sender, RoutedEventArgs e)
        {
            filteredMovies.Clear();

            if (radioAll.IsChecked == true)
            {
                RefreshScreen();
            }

             
            //Filters Action Movies
            else if (radioAction.IsChecked == true)
            {
                foreach (Movie movie in allMovies)
                {
                    if (movie.MovieGenre == MovieType.Action)
                    {
                        filteredMovies.Add(movie);
                        listboxChooseMovie.ItemsSource = null;
                        listboxChooseMovie.ItemsSource = filteredMovies;

                    }
                }
            }

            else if (radioComedy.IsChecked == true)
            {
                foreach (Movie movie in allMovies)
                {
                    if (movie.MovieGenre == MovieType.Comedy)
                    {
                        filteredMovies.Add(movie);
                        listboxChooseMovie.ItemsSource = null;
                        listboxChooseMovie.ItemsSource = filteredMovies;
                    }
                }
            }

            else if (radioDocumentary.IsChecked == true)
            {
                foreach (Movie movie in allMovies)
                {
                    if (movie.MovieGenre == MovieType.Documentaries)
                    {
                        filteredMovies.Add(movie);
                        listboxChooseMovie.ItemsSource = null;
                        listboxChooseMovie.ItemsSource = filteredMovies;
                    }
                }
            }

            else if (radioHorror.IsChecked == true)
            {
                foreach (Movie movie in allMovies)
                {
                    if (movie.MovieGenre == MovieType.Horror)
                    {
                        filteredMovies.Add(movie);
                        listboxChooseMovie.ItemsSource = null;
                        listboxChooseMovie.ItemsSource = filteredMovies;
                    }
                }
            }

            else if (radioSciFi.IsChecked == true)
            {
                foreach (Movie movie in allMovies)
                {
                    if (movie.MovieGenre == MovieType.SciFi)
                    {
                        filteredMovies.Add(movie);
                        listboxChooseMovie.ItemsSource = null;
                        listboxChooseMovie.ItemsSource = filteredMovies;
                    }
                }
            }


        }

      


        //This is used to create the description  to be shown on the textblock but when the other listbox is selected
        private void listboxChooseMovie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selected = listboxChooseMovie.SelectedItem as Movie;

            if (selected != null)
            {

                //display tblk description

                txtblockDesc.Text = selected.Description;

                //Displays the image in this listbox
                string imagePath = $"\\images\\{selected.Image}.jpg";
                imgMovie.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));

            }
        }

        private void listboxChosen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selected = listboxChosen.SelectedItem as Movie;

            if (selected != null)
            {

                //display tblk description

                txtblockDesc.Text = selected.Description;

                
                string imagePath = $"\\images\\{selected.Image}.jpg";
                imgMovie.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));

            }
        }

        private void btnNextWindow_Click(object sender, RoutedEventArgs e)
        {
            Window2 sW = new Window2();
            sW.Show();
            this.Close();
        }
    }

}
