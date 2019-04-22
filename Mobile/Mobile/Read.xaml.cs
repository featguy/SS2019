using Shared;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Read : ContentPage
    {
        private Lesson lesson = new Lesson();
        public Read()
        {
            InitializeComponent();
        }
        public Read(Lesson _lesson)
        {
            InitializeComponent();
            lesson = _lesson;
            LoadData();
        }

        private void LoadData()
        {
            StackLayout all = new StackLayout();

            //for title
            all.Children.Add(new Label()
            {
                Text = $"LESSON {lesson.Index}",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontAttributes = FontAttributes.Bold
            });

            if (!string.IsNullOrWhiteSpace(lesson.ReviewNote))
            {

                all.Children.Add(new Label()
                {
                    Text = lesson.ReviewNote.ToUpper(),
                    FontAttributes = FontAttributes.Bold,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                });
            }

            if (lesson.IsReview)
            {
                contenter.Children.Add(all);
                return;
            }

            StackLayout header1 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            StackLayout header2 = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                WidthRequest = 60,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            header2.Children.Add(new Label() { Text = "TOPIC:" });
            header2.Children.Add(new Label() { Text = "TEXT:" });
            header2.Children.Add(new Label() { Text = "AIM:" });
            header1.Children.Add(header2);

            StackLayout header3 = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            header3.Children.Add(new Label() { Text = lesson.Topic.ToUpper(), FontAttributes = FontAttributes.Bold });
            header3.Children.Add(new Label() { Text = lesson.Text });
            header3.Children.Add(new Label() { Text = lesson.Aim });
            header1.Children.Add(header3);

            all.Children.Add(header1);

            //Introduction
            FormattedString intro_format = new FormattedString() { };
            intro_format.Spans.Add(new Span() { FontAttributes = FontAttributes.Bold, Text = "INTRODUCTION: \t" });
            intro_format.Spans.Add(new Span() { Text = lesson.Introduction.Paragraphs[0] });
            if (lesson.Introduction.Paragraphs.Count() > 1)
            {
                for (int i = 1; i < lesson.Introduction.Paragraphs.Count(); i++)
                {
                    intro_format.Spans.Add(new Span() { Text = $"{Environment.NewLine} \t{lesson.Introduction.Paragraphs[i]}" });
                }
            }
            all.Children.Add(new Label() { FormattedText = intro_format });

            //Lessons
            if (lesson.Sections != null)
            {
                foreach (Section section in lesson.Sections)
                {
                    all.Children.Add(new Label()
                    {
                        Text = $"{section.Alphabeth}.\t{section.Title} {section.BibleVerse ?? string.Empty}",
                        FontAttributes = FontAttributes.Bold
                    });
                    all.Children.Add(new Label()
                    {
                        Text = section.Body,
                    });

                    if (section.SubSections != null)
                    {
                        foreach (SubSection subsession in section.SubSections)
                        {
                            StackLayout sub_stack = new StackLayout() { Orientation = StackOrientation.Horizontal };
                            sub_stack.Children.Add(new Label() { Text = $"{subsession.Index} \t" });

                            FormattedString sub_session_format = new FormattedString() { };
                            
                            if (!string.IsNullOrWhiteSpace(subsession.Title))
                            {
                                sub_session_format.Spans.Add(new Span() { FontAttributes = FontAttributes.Italic, Text = $"{subsession.Title} " });
                            }

                            if (!string.IsNullOrWhiteSpace(subsession.MemoryVerse))
                            {
                                sub_session_format.Spans.Add(new Span() { Text = $"{subsession.MemoryVerse} " });
                            }

                            if (!string.IsNullOrWhiteSpace(subsession.Body))
                            {
                                sub_session_format.Spans.Add(new Span() { Text = subsession.Body });
                            }

                            sub_stack.Children.Add(new Label()
                            {
                                FormattedText = sub_session_format,
                                HorizontalOptions = LayoutOptions.StartAndExpand
                            });
                            all.Children.Add(sub_stack);

                            //for RomanSubsession
                            if (subsession.RomanSubSections != null)
                            {
                                foreach (RomanSubSection roman_subsession in subsession.RomanSubSections)
                                {
                                    StackLayout roman_sub_stack = new StackLayout() { Orientation = StackOrientation.Horizontal };
                                    roman_sub_stack.Children.Add(new Label() { Text = $"{roman_subsession.RomanIndex} \t" });
                                    FormattedString roman_sub_session_format = new FormattedString();
                                    if (!string.IsNullOrWhiteSpace(roman_subsession.Title))
                                    {
                                        roman_sub_session_format.Spans.Add(new Span() { FontAttributes = FontAttributes.Bold, Text = roman_subsession.Title });
                                    }

                                    if (!string.IsNullOrWhiteSpace(roman_subsession.BibleVerse))
                                    {
                                        roman_sub_session_format.Spans.Add(new Span() { Text = roman_subsession.BibleVerse });
                                    }

                                    if (!string.IsNullOrWhiteSpace(roman_subsession.Body))
                                    {
                                        roman_sub_session_format.Spans.Add(new Span() { Text = roman_subsession.Body });
                                    }

                                    roman_sub_stack.Children.Add(new Label()
                                    {
                                        FormattedText = roman_sub_session_format,
                                        HorizontalTextAlignment = TextAlignment.Start,
                                        HorizontalOptions = LayoutOptions.StartAndExpand
                                    });

                                    all.Children.Add(roman_sub_stack);

                                }
                            }
                        }
                    }
                }
            }

            //Extras

            if (!string.IsNullOrWhiteSpace(lesson.Conclusion))
            {
                FormattedString conclusion_formatted = new FormattedString();

                conclusion_formatted.Spans.Add(new Span()
                {
                    Text = "CONCLUSION: \t",
                    FontAttributes = FontAttributes.Bold
                });
                conclusion_formatted.Spans.Add(new Span()
                {
                    Text = lesson.Conclusion,
                });
                all.Children.Add(new Label() { FormattedText = conclusion_formatted });
            }

            if (!string.IsNullOrWhiteSpace(lesson.ClosingRemarks))
            {
                FormattedString closing_formatted = new FormattedString();
                closing_formatted.Spans.Add(new Span()
                {
                    Text = "CLOSING REMARKS: \t",
                    FontAttributes = FontAttributes.Bold
                });
                closing_formatted.Spans.Add(new Span()
                {
                    Text = lesson.ClosingRemarks,
                });
                all.Children.Add(new Label() { FormattedText = closing_formatted });
            }
            if (!string.IsNullOrWhiteSpace(lesson.MemoryVerse))
            {
                FormattedString memory_formatted = new FormattedString();
                memory_formatted.Spans.Add(new Span()
                {
                    Text = "MEMORY VERSE: \t",
                    FontAttributes = FontAttributes.Bold
                });
                memory_formatted.Spans.Add(new Span()
                {
                    Text = lesson.MemoryVerse,
                });
                all.Children.Add(new Label() { FormattedText = memory_formatted });

            }
            if (!string.IsNullOrWhiteSpace(lesson.Challenge))
            {
                FormattedString challenge_formatted = new FormattedString();
                challenge_formatted.Spans.Add(new Span()
                {
                    Text = "CHALLENGE: \t",
                    FontAttributes = FontAttributes.Bold
                });
                challenge_formatted.Spans.Add(new Span()
                {
                    Text = lesson.Challenge,
                });
                all.Children.Add(new Label() { FormattedText = challenge_formatted });

            }

            contenter.Children.Add(all);
        }
    }
}