﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.Factory
{
    abstract class Page
    {

    }

    class SkillsPage : Page
    {

    }

    class EducationPage : Page
    {
    }

    class ExperiencePage : Page
    {
    }

    class IntroductionPage : Page
    {
    }

    class ResultsPage : Page
    {
    }

    class ConclusionPage : Page
    {
    }
    class SummaryPage : Page
    {
    }
    class BibliographyPage : Page
    {
    }

    public abstract class Document
    {
        private List<Page> _pages { get; set; }

        public Document()
        {
            // 創造一個文件的範本，每一頁的內容都不盡相同
            _pages = new List<Page>();
            // 範本要放置內頁面由文件種類來決定
            this.CreatePages();
        }

        public abstract void CreatePages();
    }
}
