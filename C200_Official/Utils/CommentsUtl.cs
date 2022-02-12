using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C200_Official.Models;

public class CommentsUtl
{
    public List<ArticleComment> sortByLatestComments(List<ArticleComment> article)
    {
        List<ArticleComment> sortedCommentList = article;

        for (int i = 0; i < sortedCommentList.Count(); i++)
        {
            ArticleComment selectedComment = sortedCommentList[i];
            for (int j = i + 1; j < sortedCommentList.Count(); j++)
            {
                ArticleComment selectedComment2 = sortedCommentList[j];
                if (DateTime.Compare(selectedComment2.DatePublished, selectedComment.DatePublished) > 0) //date comparision, if 1st date bigger than 2nd date, 1 will be returned
                {
                    var temp = sortedCommentList[i]; //i is not the lastest
                    sortedCommentList[i] = sortedCommentList[j]; //put j into i as i is in temp alr
                    sortedCommentList[j] = temp;
                }
            }
        }
        return sortedCommentList;
    }

    public List<VideoComment> sortByLatestVideoComments(List<VideoComment> video)
    {
        List<VideoComment> sortedVideoCommentList = video;

        for (int i = 0; i < sortedVideoCommentList.Count(); i++)
        {
            VideoComment selectedComment = sortedVideoCommentList[i];
            for (int j = i + 1; j < sortedVideoCommentList.Count(); j++)
            {
                VideoComment selectedVideoComment2 = sortedVideoCommentList[j];
                if (DateTime.Compare(selectedVideoComment2.CommentDate, selectedComment.CommentDate) > 0) //date comparision, if 1st date bigger than 2nd date, 1 will be returned
                {
                    var temp = sortedVideoCommentList[i]; //i is not the lastest
                    sortedVideoCommentList[i] = sortedVideoCommentList[j]; //put j into i as i is in temp alr
                    sortedVideoCommentList[j] = temp;
                }
            }
        }
        return sortedVideoCommentList;
    }

        public List<Answer> sortByLatestComments(List<Answer> answers, bool QnAFlag) //QNA FLAG to know they are checking for ans sorting 
    {
        List<Answer> sortedAnswerList = answers;

        for (int i = 0; i < sortedAnswerList.Count(); i++)
        {
            Answer selectedComment = sortedAnswerList[i];
            for (int j = i + 1; j < sortedAnswerList.Count(); j++)
            {
                Answer selectedComment2 = sortedAnswerList[j];
                if (DateTime.Compare(selectedComment2.AnsweredDate, selectedComment.AnsweredDate) > 0) //date comparision, if 1st date bigger than 2nd date, 1 will be returned
                {
                    var temp = sortedAnswerList[i]; //i is not the lastest
                    sortedAnswerList[i] = sortedAnswerList[j]; //put j into i as i is in temp alr
                    sortedAnswerList[j] = temp;
                }
            }
        }
        return sortedAnswerList;
    }

    //SORT Latest ARTICLES
    public List<Article> sortByLatestArticles(List<Article> articles)
    {
        List<Article> sortedArticleList = articles;

        for (int i = 0; i < sortedArticleList.Count(); i++)
        {
            Article selectedArticle = sortedArticleList[i];
            for (int j = i + 1; j < sortedArticleList.Count(); j++)
            {
                Article selectedArticle2 = sortedArticleList[j];
                if (DateTime.Compare(selectedArticle2.SubmittedOn, selectedArticle.SubmittedOn) > 0) //date comparision, if 1st date bigger than 2nd date, 1 will be returned
                {
                    var temp = sortedArticleList[i]; //i is not the lastest
                    sortedArticleList[i] = sortedArticleList[j]; //put j into i as i is in temp alr
                    sortedArticleList[j] = temp;
                }
            }
        }
        return sortedArticleList;
    }


    //SORT Latest VIDEOS
    public List<Video> sortByLatestVideos(List<Video> videos)
    {
        List<Video> sortedVideoList = videos;

        for (int i = 0; i < sortedVideoList.Count(); i++)
        {
            Video selectedVideo = sortedVideoList[i];
            for (int j = i + 1; j < sortedVideoList.Count(); j++)
            {
                Video selectedVideo2 = sortedVideoList[j];
                if (DateTime.Compare(selectedVideo2.SubmittedOn, selectedVideo.SubmittedOn) > 0) //date comparision, if 1st date bigger than 2nd date, 1 will be returned
                {
                    var temp = sortedVideoList[i]; //i is not the lastest
                    sortedVideoList[i] = sortedVideoList[j]; //put j into i as i is in temp alr
                    sortedVideoList[j] = temp;
                }
            }
        }
        return sortedVideoList;
    }


}
