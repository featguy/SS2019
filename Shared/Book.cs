using System;
using System.Collections.Generic;

namespace Shared
{
    public class Book
    {
        public Book()
        {
            this.Title = "SUNDAY SCHOOL MANUAL";
            this.Year = 2019;
            this.Region = "ECWA SOUTH WEST";
            this.Lessons = new List<Lesson>() {
                new Lesson() {
                      Index =1,
                       Topic = "THE PERFECT PLANNER",
                       Text ="Jeremiah 29:11-13",
                        Aim = "That we as Christians may involve God in our planning for the New Year.",
                        Introduction = new Introduction(){
                            Paragraphs = new string[] { @"Every New Year arrives with 365 days. These many days, if not well planned for, may end up being wasted and our dreams, hopes and expectations may be disappointed.  We therefore need the help of God to help us in our planning for the year. He is perfect in all His ways and able to make our ways perfect (Psalm 18:32)." },

            },
                         Sections = new List<Section>(){
                              new Section(){
                                   Alphabeth ="A", Title = "BELIEVER’S HOPE IN THE NEW YEAR",
                                    Body = "Every believer hopes for some specific blessings from God for the new year. Among them are:",
                                     SubSections = new List<SubSection>(){
                                         new SubSection(){ Index=1, Title ="Spiritual growth.", MemoryVerse="(2 Peter 3:18)", Body = "One hope common to every true child of God is the expectation to grow more spiritually, becoming like Christ. It is also the expectation of God, our heavenly Father. He wants to see us grow spiritually. We must therefore make adequate plan to make this hope become a reality.   " },
                                         new SubSection(){ Index=2, Title="Marital bliss.", MemoryVerse="(Proverbs 5:18)", Body ="Members of every family hope to dwell together in peace and joy." },
                                         new SubSection(){ Index=3, Title ="Career development.", MemoryVerse="(Proverbs 22:29)", Body ="Progress and promotion at work, business or the work of our hands is one strong desire and hope of every believer. This is quit in order because God promises to prosper the work of our hands."},
                                         new SubSection(){ Index=4, Title="Provision for all we need for our physical survival.", MemoryVerse="(Matthew 6:11; Philippians 4:19)", Body="Human needs are insatiable. This need is more pressing because of the current economic challenges that affect everyone, believers inclusive." },
                                         new SubSection(){ Index=5, Title="Sound health.", MemoryVerse="(3 John 2)", Body="Health is wealth. As believers we all desire good health.  This is why we all pray for it and against ill-health and afflictions as we begin the New Year." },
                                         new SubSection(){ Index=6, Title="Improved relationship with others.", MemoryVerse="(Matthew 5:16; Romans 12:18)", Body="Our calling as believers bestows on us the grace and privilege of being able to reach out effectively to the world around us. This we do as light, showing the true and right way to live, and as salt making positive impact. This is one hope we should all have." }
                                     },

                              },
                              new Section()
                              {
                                  Alphabeth = "B", Title ="GOD, THE PERFECT PLANNER",
                                  Body = "The realization of all our hopes and dreams are subject to our planning. And our planning is faced with our limitations as humans. We however, have a Father who is perfect and can make our ways perfect (Psalm 18:32). He is well able to help us as a perfect planner because of the following:",
                                  SubSections = new List<SubSection>()
                                  {
                                      new SubSection(){ Index =1, Title ="God is our Creator.", MemoryVerse="(John 1:1-4)", Body = "We are not strangers to God. He made us. He knows our frame, strength, abilities, weaknesses and the aspects of our lives that are unknown to us." },
                                       new SubSection(){ Index =2, Title ="God is all-knowing.", MemoryVerse="(Daniel 2:19-22)", Body = "Beyond creating us and knowing all about our make-up, God knows all about the year, the world and all that pertains to life and godliness. He is not in want of any information. Nothing is hidden before Him and nothing is a mystery to Him. This makes His decisions, judgments and actions well-informed and perfect." },
                                        new SubSection(){ Index =3, Title ="He is a God of all possibilities." , MemoryVerse="(Genesis 18:14; Luke 1:37)", Body = "One distinct attribute of our God is His ability to do all things. Nothing is impossible for Him. When He is involved in any plan, He makes it possible when those concerned believe in Him and obey Him. " },
                                         new SubSection(){ Index =4, Title ="God is all-powerful." , MemoryVerse="(Isaiah 41:13-15)", Body = "His ability to do all things is never faced with challenges. This is because all power resides with Him. Not just the power we need or require to do a thing, but all and every power is His." },
                                          new SubSection(){ Index =5, Title ="God is merciful, gracious and kind." , MemoryVerse="(Psalm 103:8)", Body = "Even though our God is all-powerful, He also relates with us in tender mercy, grace and kindness. He bears us as a Father who understands our frailty and struggles. He is therefore able to feel with us and help us in the journey of the year." },
                                           new SubSection(){ Index =6, Title ="God desires the good of His children." , MemoryVerse="(Jeremiah 29:11)", Body = "The awesomeness of our God is demonstrated in His thoughts and plans for us. It is so amazing that before we even think of plans, God takes the initiative and desires the good of His children." },
                                            new SubSection(){ Index =7, Title ="He is a righteous God." , MemoryVerse="(Psalm 145:17)", Body = "It is assuring to know that God brings all these attributes of His to bear in planning with us in a righteous way when we involve Him. He takes no advantage of us because of who He is, but deals with us righteously." },
                                  }
                              },
                              new Section()
                              {
                                  Alphabeth = "C", Title ="HOW TO RESPOND TO THE PERFECT PLANNER",
                                  SubSections = new List<SubSection>()
                                  {
                                      new SubSection(){ Index =1, Title ="Acknowledge God." , MemoryVerse="(Proverbs 3:5-7)", Body ="We are often tempted to think we can handle things on our own. Leaning on our understanding can fail because, as humans, we can fail. It is therefore necessary that in all our ways, we acknowledge God. This is especially necessary while planning for the New Year. God alone cannot fail." },
                                      new SubSection(){ Index =2, Title ="Fear God." , MemoryVerse="(Proverbs 1:7)", Body ="We should consider God’s attributes in our deliberations, and live in the light of His presence. Doing so will make us wise. This is because we are engaging God with whom all things are possible, and with whom there is every assurance and help. " },
                                      new SubSection(){ Index =3, Title ="Depend solely on God’s word." , MemoryVerse="(Joshua 1:8, 9)", Body ="God is sufficiently able to do all things. When we put our trust in Him and in His word, we don’t need to complement Him with other ways or wisdom contrary to His. " },
                                      new SubSection(){ Index =4, Title ="Turn away from sin." , MemoryVerse="(Isaiah 1:18, 19)", Body ="The only way to get God involved in our plans is to avoid sin.  He does not turn away sinners who come to Him in repentance. But for there to be continuity with Him, he who comes to Him must turn away from sin. Until then, there will be no blessings." },
                                      new SubSection(){ Index =5, Title ="Plan with eternity in view." , MemoryVerse="(Mark 8:36)", Body ="There is no gain planning with God for things that have no eternal value. We should plan for and seek God’s involvement only in matters that pertain to eternal life that we have in Christ, and for our living here on earth with eternity in view." },
                                      new SubSection(){ Index =6, Title ="Present your vision and goal to the Great Planner and work towards them." , MemoryVerse="(Psalm 32:8)", Body ="When we acknowledge God for who He is, we are also, by implication, acknowledging our dependence on Him. We are also declaring that we allow Him lead us. It is as we seek first His kingdom and its righteousness that He adds to us all the other things we need (Matthew 6:33)." },
                                      new SubSection(){ Index =7, Title ="Prepare to affect others positively." , MemoryVerse="(Matthew 5:13-16)", Body ="In Christ we have a new identity and purpose that should affect the world by our good works, and that should glorify God because of those impacted by our good works. So our plans should include our ministry to others." },
                                  }
                              }

                         }, MemoryVerse = "Jeremiah 29:11", Date = new DateTime(2019,01,06)
                },
                new Lesson(){ },

            };
        }
        public List<Lesson> Lessons { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Region { get; set; }
    }

    public class Lesson
    {
        public int Index { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }
        public string Aim { get; set; }
        public Introduction Introduction { get; set; }
        public List<Section> Sections { get; set; }
        public string Conclusion { get; set; }          //usually capital letters
        public string Challenge { get; set; }          //usually capital letters
        public string ClosingRemarks { get; set; }          //usually capital letters
        public string MemoryVerse { get; set; }         //usually capital letters
        public string ReviewNote { get; set; }
        public bool IsReview { get; set; } = false;
        public DateTime Date { get; set; }
    }
    public class Introduction
    {
        public string[] Paragraphs { get; set; }
    }
    public class Section
    {
        public string Alphabeth { get; set; }
        public string Title { get; set; }               //usually bold
        public string Body { get; set; }          //usually capital letters
        public string BibleVerse { get; set; }
        public List<SubSection> SubSections { get; set; }
    }
    public class SubSection
    {
        public int Index { get; set; }
        public string Title { get; set; }               //usually bold
        public string MemoryVerse { get; set; }
        public string Body { get; set; }
        public List<RomanSubSection> RomanSubSections { get; set; }
    }
    public class RomanSubSection
    {
        public string RomanIndex { get; set; }
        public string Title { get; set; }               //usually bold
        public string Body { get; set; }
        public string BibleVerse { get; set; }
    }
}
