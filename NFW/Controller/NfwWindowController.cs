using NFW.Model;
using NFW.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace NFW.Controller
{
    internal class NfwWindowController
    {
        private List<UserControl> m_pageViews;
        private int m_curPageIndex;
        private NfwPageController m_pageController;

        private NfwWindow m_window { get; set; }

        internal NfwWindowController()
        {
            m_pageViews = new List<UserControl>();
            m_pageController = new NfwPageController();
            m_curPageIndex = -1;

            m_window = new NfwWindow(this);
        }

        internal bool AddPage(string header, string text, Uri imgUri)
        {
            PageHeader pgHeader = new PageHeader() { Text = header };
            PageText pgText = new PageText() { Text = text };
            PageBackground pgBackground = new PageBackground() { ImageUri = imgUri };

            m_pageViews.Add(m_pageController.Create(new NfwPage(pgHeader, pgBackground, pgText)));

            if (!m_window.IsActive)
            {
                Display();
            }

            return true;
        }

        internal void Display()
        {
            m_window.Show();
            NextPage();
        }

        public bool Display(UserControl pageView)
        {
            pageView.Height = m_window.m_contentPage.Height;
            pageView.Width = m_window.m_contentPage.Width;
            m_window.m_contentPage.Content = pageView;
            return true;
        }

        internal void Close()
        {
            m_window.Close();
        }

        internal void NextPage()
        {
            if (m_curPageIndex + 1 < m_pageViews.Count)
            {
                Display(m_pageViews.ElementAt(++m_curPageIndex));
            }
            else
            {
                Close();
            }
        }

        internal void PrevPage()
        {
            if (m_curPageIndex - 1 >= 0)
            {
                Display(m_pageViews.ElementAt(--m_curPageIndex));
            }
        }
    }
}
