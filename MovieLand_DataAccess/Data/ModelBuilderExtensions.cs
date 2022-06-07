﻿using Microsoft.EntityFrameworkCore;
using MovieLand_Models;

namespace MovieLand_DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void GenerateData(this ModelBuilder modelBuilder)
        {
            #region Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "L'affaire Pélican", ReleaseYear = 1993, Runtime = 141, Poster  = "SY23IX2QWdXCiX2YkIerTweUcd.jpg" },
                new Movie { MovieId = 2, Title = "Spider-Man", ReleaseYear = 2002, Runtime = 121, Poster  = "pNz1NREgddPdlzytlR8mW4B26fW.jpg" },
                new Movie { MovieId = 3, Title = "Scooby-Doo", ReleaseYear = 2002, Runtime = 89, Poster  = "32bzh3HnRZdE8oM9pwfmGJUYnvl.jpg" },
                new Movie { MovieId = 4, Title = "L'interprète", ReleaseYear = 2005, Runtime = 128, Poster  = "e2oWzbhxfqAlJ83ea38D64VD1RR.jpg" },
                new Movie { MovieId = 5, Title = "M. et Mme Smith", ReleaseYear = 2005, Runtime = 120, Poster  = "wzIO3ytxeSNt1wRpXLIdkNbGoDm.jpg" },
                new Movie { MovieId = 6, Title = "The Legend of Zorro", ReleaseYear = 2005, Runtime = 129, Poster  = "hjWcpt9GI9v9NSkex58GUZhlS25.jpg" },
                new Movie { MovieId = 7, Title = "Le code Da Vinci", ReleaseYear = 2006, Runtime = 149, Poster  = "q6wt3HwGwRnzKbpgwNTeIZgHKkH.jpg" },
                new Movie { MovieId = 8, Title = "Prémonition", ReleaseYear = 2007, Runtime = 93, Poster  = "x7zBSbzWyJB1VB10BAMMWTOWe45.jpg" },
                new Movie { MovieId = 9, Title = "Fracture", ReleaseYear = 2007, Runtime = 113, Poster  = "svCEllDaXbt3eNlbf4HZLA5kKjJ.jpg" },
                new Movie { MovieId = 10, Title = "Spider-Man 3", ReleaseYear = 2007, Runtime = 139, Poster  = "4SBTOPWMM3My5nDIlpNHt6dg78d.jpg" },
                new Movie { MovieId = 11, Title = "L'Incroyable Hulk", ReleaseYear = 2008, Runtime = 113, Poster  = "7zEWoMDAgvgHlv1D11vF3Br3ZTd.jpg" },
                new Movie { MovieId = 12, Title = "L'Oeil du mal", ReleaseYear = 2008, Runtime = 118, Poster  = "lLbElXAzCNxaCaHGBDvLv7KM9QM.jpg" },
                new Movie { MovieId = 13, Title = "Prédictions", ReleaseYear = 2009, Runtime = 121, Poster  = "uvd0fOK5dZsZDMICflMxotedsmC.jpg" },
                new Movie { MovieId = 14, Title = "State of Play", ReleaseYear = 2009, Runtime = 127, Poster  = "cAFfhia4joDvGK2zvL6lOue6Xlx.jpg" },
                new Movie { MovieId = 15, Title = "Anges & Démons", ReleaseYear = 2009, Runtime = 138, Poster  = "zS0B5iu68dyBNXUoSpZmIaxh2ua.jpg" },
                new Movie { MovieId = 16, Title = "Hors de moi", ReleaseYear = 2011, Runtime = 113, Poster  = "OuABrWGUHbIAmaE0wkmNMvy1A7.jpg" },
                new Movie { MovieId = 17, Title = "Sans limites", ReleaseYear = 2011, Runtime = 105, Poster  = "786fsgu3U7P9icbllwpd6yfOIiD.jpg" },
                new Movie { MovieId = 18, Title = "Green Lantern", ReleaseYear = 2011, Runtime = 123, Poster  = "7MMrRbyOts9v1YHYoc7LSrz8XnQ.jpg" },
                new Movie { MovieId = 19, Title = "Johnny English renaît", ReleaseYear = 2011, Runtime = 101, Poster  = "bRMdfPlHNbnpifEUIOEajxl8BcX.jpg" },
                new Movie { MovieId = 20, Title = "Sherlock Holmes: Le jeu des ombres", ReleaseYear = 2011, Runtime = 129, Poster  = "kbeSPWIRkWZYQgLCyPqxjj4G0kx.jpg" },
                new Movie { MovieId = 21, Title = "Ghost Rider: Esprit de vengeance", ReleaseYear = 2011, Runtime = 95, Poster  = "i0jXQFuSsKLDNxWH7mV0BijugtY.jpg" },
                new Movie { MovieId = 22, Title = "L'extraordinaire Spider-Man", ReleaseYear = 2012, Runtime = 137, Poster  = "gsIkMf1VErbF0xtrgXEZXqLgsBG.jpg" },
                new Movie { MovieId = 23, Title = "Total Recall: Mémoires programmées", ReleaseYear = 2012, Runtime = 121, Poster  = "sqKvTMHHbkH5ak4jPIPHCTQqb6W.jpg" },
                new Movie { MovieId = 24, Title = "Emprise sur la ville", ReleaseYear = 2013, Runtime = 109, Poster  = "hagmYjjQBR5I73YFsYMXMY2Uoj3.jpg" },
                new Movie { MovieId = 25, Title = "Parker", ReleaseYear = 2013, Runtime = 118, Poster  = "n3pCxunmHrK6AWpLaAThgYiguWK.jpg" },
                new Movie { MovieId = 26, Title = "Insaisissable", ReleaseYear = 2013, Runtime = 115, Poster  = "mskYkcgAMCOKncFMfTWAHL5sUTo.jpg" },
                new Movie { MovieId = 27, Title = "L'homme d'acier", ReleaseYear = 2013, Runtime = 143, Poster  = "cB46TSg3kGjq2eVy5kVUhlpUa1H.jpg" },
                new Movie { MovieId = 28, Title = "Sans arrêt", ReleaseYear = 2014, Runtime = 107, Poster  = "Nkgaj3X0W2jHQ1TzHEgWFpN3kJ.jpg" },
                new Movie { MovieId = 29, Title = "Predestination", ReleaseYear = 2014, Runtime = 97, Poster  = "pn0bw4DDYVarCLBbWRg1DWUkZPX.jpg" },
                new Movie { MovieId = 30, Title = "Entre les tombes", ReleaseYear = 2014, Runtime = 114, Poster  = "e2sct49Yw8EJsBWT3gdmAOpEY9Y.jpg" },
                new Movie { MovieId = 31, Title = "Focus", ReleaseYear = 2015, Runtime = 105, Poster  = "AfKm745YiKJ14yp4UfA4jowBIPi.jpg" },
                new Movie { MovieId = 32, Title = "Dangereux 7", ReleaseYear = 2015, Runtime = 137, Poster  = "wjVn1Qng8B3ySvfJr4ovuehI141.jpg" },
                new Movie { MovieId = 33, Title = "Insaisissable 2", ReleaseYear = 2016, Runtime = 129, Poster  = "w7Q9BAqpbPHSeo6ZDYRpFGpGUxn.jpg" },
                new Movie { MovieId = 34, Title = "Jason Bourne", ReleaseYear = 2016, Runtime = 124, Poster  = "cqvNVmn25vCmBcbwSfR1KlSOBBH.jpg" },
                new Movie { MovieId = 35, Title = "Inferno", ReleaseYear = 2016, Runtime = 122, Poster  = "bCqD2c1nJJY6q65VGBfMItgVvGx.jpg" },
                new Movie { MovieId = 36, Title = "iBoy", ReleaseYear = 2017, Runtime = 90, Poster  = "aqwQPVosPSjfXRF6bO9Wg48ylAR.jpg" },
                new Movie { MovieId = 37, Title = "Spider-man : Les retrouvailles", ReleaseYear = 2017, Runtime = 133, Poster  = "77Z0g5fc1qWJ7SfHyeiHsMkYx5O.jpg" },
                new Movie { MovieId = 38, Title = "Mon meilleur ennemi", ReleaseYear = 2017, Runtime = 118, Poster  = "2oc9wS0PjiBVCnAvYqmenCQdRLO.jpg" },
                new Movie { MovieId = 39, Title = "Jumanji : Bienvenue dans la jungle", ReleaseYear = 2017, Runtime = 119, Poster  = "y1zgYmxkQDvi9Tev74PYbmer2Mv.jpg" },
                new Movie { MovieId = 40, Title = "Venom", ReleaseYear = 2018, Runtime = 112, Poster  = "vVusHIRlyyFVS42XnqZso2wGKr.jpg" },
                new Movie { MovieId = 41, Title = "Meurtre et mystère", ReleaseYear = 2019, Runtime = 97, Poster  = "bSMSO9xupd4R4vwTPqigHn2quLN.jpg" },
                new Movie { MovieId = 42, Title = "Spider-Man : Loin des siens", ReleaseYear = 2019, Runtime = 129, Poster  = "zrNKUa5SBUwue39coJArNdDgQJM.jpg" },
                new Movie { MovieId = 43, Title = "Rapides et dangereux présentent: Hobbs et Shaw", ReleaseYear = 2019, Runtime = 137, Poster  = "kgajCPm5pdH2Sa3CTCyHuUmQvgT.jpg" },
                new Movie { MovieId = 44, Title = "Terminator : Sombre destin", ReleaseYear = 2019, Runtime = 128, Poster  = "hiHsAVw2M6j3JHUOPoqAR7X55iB.jpg" },
                new Movie { MovieId = 45, Title = "Sonic le hérisson", ReleaseYear = 2020, Runtime = 99, Poster  = "vwuNoe7sCWxZw7Feo3iIhym5rKM.jpg" },
                new Movie { MovieId = 46, Title = "Spenser : la justice à tout prix", ReleaseYear = 2020, Runtime = 110, Poster  = "fePczipv6ZzDO2uoww4vTAu2Sq3.jpg" },
                new Movie { MovieId = 47, Title = "L'Art du crime", ReleaseYear = 2020, Runtime = 101, Poster  = "fNXKcqfD252Kk52AJb6arCYCDlS.jpg" },
                new Movie { MovieId = 48, Title = "Scooby!", ReleaseYear = 2020, Runtime = 93, Poster  = "4xiq5NpooMCBFjQhGQjx8LqmhTy.jpg" },
                new Movie { MovieId = 49, Title = "The Old Guard", ReleaseYear = 2020, Runtime = 125, Poster  = "pSGO3h6Cyqgv1bDbkjzxUlU8jsW.jpg" },
                new Movie { MovieId = 50, Title = "La nuit où on a sauvé Maman", ReleaseYear = 2020, Runtime = 103, Poster  = "k342BTraGregKSIVrrH7AGqoKna.jpg" },
                new Movie { MovieId = 51, Title = "Enola Holmes", ReleaseYear = 2020, Runtime = 123, Poster  = "zDtraIGPVhmSnPZQ34fmyvWT5tz.jpg" },
                new Movie { MovieId = 52, Title = "La femme à la fenêtre", ReleaseYear = 2021, Runtime = 102, Poster  = "gS1C3cIXJXHZbW00PtWy1bSdorH.jpg" },
                new Movie { MovieId = 53, Title = "La femme de mon meilleur ennemi", ReleaseYear = 2021, Runtime = 117, Poster  = "dFMu4ZfJf0tfgJkR0x3sRpeG0Rj.jpg" },
                new Movie { MovieId = 54, Title = "L'armée des voleurs", ReleaseYear = 2021, Runtime = 127, Poster  = "iPTZGFmPs7HsXHYxiuxGolihjOH.jpg" },
                new Movie { MovieId = 55, Title = "Adam à travers le temps", ReleaseYear = 2022, Runtime = 106, Poster  = "5OCzQvJ0ePPx66OPGVC6ga9bUUQ.jpg" }
            );
            #endregion
        }
    }
}
